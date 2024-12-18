import csv
import math
from datetime import datetime
import re
import pandas as pd
import numpy as np

pd.set_option('future.no_silent_downcasting', True)

def week_of_month(date):
    """Calculates the week of the month for a given date."""

    first_day = date.replace(day=1)
    dom = date.day
    adjusted_dom = dom + first_day.weekday()

    return int(math.ceil(adjusted_dom / 7.0))

def handle_currency_column(df: pd.DataFrame) -> pd.DataFrame:
    for column in df.columns:
        try:
            df[column] = (
                df[column]
                .replace(r"[\$,)]", "", regex=True)
                .replace(r"[\",)]", "", regex=True)
                .replace(r"[\%]", "", regex=True)
                .replace("[(]", "-", regex=True)
                .replace(" ", "", regex=True)
                .replace(r"[\|]", "", regex=True)
                .astype(float)
            )
        except Exception as e:
            # do nothing if column is a non numeric string column
            """if column == 'Market Cap':
                print(f"Error while converting column {column} to float. Error: {e}")"""
            continue
    return df


def convert_date(date_str):
    formats = ['%m/%d/%y', '%m/%d/%Y']
    for fmt in formats:
        try:
            return pd.to_datetime(date_str, format=fmt)
        except ValueError:
            pass
    raise ValueError('No valid date format found')


def handle_date_column(df: pd.DataFrame) -> pd.DataFrame:
    for column in df.columns:
        try:
            df[column] = df[column].apply(convert_date).dt.date
            df[column] = df[column].dt.date
        except Exception as e:
            # do nothing if column is a non date string column
            # print(f"Error while converting column {column} to date. Error: {e}")
            continue
    return df


def read_csv_skip_duplicates_usa(file_path, date):
    col_row = 4
    # Read the header row first
    with open(file_path, 'r') as f:
        ex = f.readline()
        for i in range(col_row - 2):
            f.readline()
        header = f.readline().strip().split(',')

    # Identify duplicate column names
    seen = set()
    duplicate_cols = [col for col in header if col.casefold() in (name.casefold() for name in seen) or seen.add(col)]

    # Read the CSV, excluding duplicate columns
    df = pd.read_csv(file_path, usecols=[col for col in header if col not in duplicate_cols], header=2, thousands=",")

    cleanup_values = {r'^custom.*$': None, r'^loading.*$': None, r'^Error.*$': None, r'^<empty>$': None, r'^NaN$': None,
                      r'^-$': None, r'^--$': None, r'^\+\+$': None}

    df = df.replace(cleanup_values, regex=True)
    df = handle_currency_column(df)
    df = handle_date_column(df)
    df = df.replace({np.nan: None})

    ex = re.sub('[^A-Za-z0-9 ]+', '', ex)
    df['EX'] = ex
    df['DATE'] = pd.to_datetime(date, yearfirst=True)
    df['DAYOFWEEK'] = pd.to_datetime(date, yearfirst=True).strftime('%A')

    return df.copy()

def read_csv_skip_duplicates_can(file_path, date):
    # Read the header row first
    with open(file_path, 'r') as f:
        header = f.readline().strip().split('|')

    # Identify duplicate column names
    seen = set()
    duplicate_cols = [col for col in header if col.casefold() in (name.casefold() for name in seen) or seen.add(col)]

    # Read the CSV, excluding duplicate columns
    df = pd.read_csv(file_path, skip_blank_lines=True, sep='|', thousands='|')

    """data = df_temp.data.str.replace('"', '', regex=True)
    tmp_cols = data[0].split('|')
    tmp_rows = data[1:].str.split('|').tolist()

    # create a new data frame by splitting the single column above on a pipe using lines 1:<end>, use line 0 as the header, splitting it using the same logic.
    df = pd.DataFrame(data=data[1:].str.split('|').tolist(), columns=data[0].split('|'))"""

    cleanup_values = {r'^-$': None, r'^--$': None, r'^\+\+$': None, r'^―$': None}

    df = df.replace(cleanup_values, regex=True)
    df = handle_currency_column(df)
    df = handle_date_column(df)
    df = df.replace({np.nan: None})

    df['DATE'] = pd.to_datetime(date, yearfirst=True)
    df['DAYOFWEEK'] = pd.to_datetime(date, yearfirst=True).strftime('%A')
    df['WEEKOFMONTH'] = f'M{week_of_month(pd.to_datetime(date, yearfirst=True))}'
    df['WEEKOFYEAR'] = 'Y'+pd.to_datetime(date, yearfirst=True).strftime('%U')

    return df.copy()
