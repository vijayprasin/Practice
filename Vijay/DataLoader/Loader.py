from SqlHelper import insert_into_table
from ReadFromCSV import read_csv_skip_duplicates_usa, read_csv_skip_duplicates_can
import os

#dir_path_usa = 'C:/Users/mukil/OneDrive/Documents/Projects/DataEngineering/Input/USA/'
#dir_path_usa = 'C:/Users/rames/Downloads/Interview/done/Mulikan/DataEngineering-2024-10-20/Input/USA/'
dir_path_usa ='/Users/vijay/Desktop/Vijay/USA/'
#dir_path_can = 'C:/Users/mukil/OneDrive/Documents/Projects/DataEngineering/Input/Canada/'
#dir_path_can = 'C:/Users/rames/Downloads/Interview/done/Mulikan/DataEngineering-2024-10-20/Input/Canada/'
dir_path_can='/Users/vijay/Desktop/Vijay/Canada/'

for subdir, dirs, files in os.walk(dir_path_usa):
    for file in files:
        filename = os.fsdecode(file)
        file_path = subdir + os.sep + file
        date = os.path.basename(subdir)
        if file_path.endswith(".csv"):
            try:
                # Read the CSV file
                df_usa = read_csv_skip_duplicates_usa(file_path, date)
                #insert into database
                insert_into_table(df_usa, 'StocksUSARowBased')
                insert_into_table(df_usa, 'StocksUSAColumnar')
            except Exception as ex:
                print(ex)
                continue

for subdir, dirs, files in os.walk(dir_path_can):
    for file in files:
        filename = os.fsdecode(file)
        file_path = subdir + os.sep + file
        date = os.path.basename(subdir)
        if file_path.endswith(".csv"):
            try:
                # Read the CSV file
                df_can = read_csv_skip_duplicates_can(file_path, date)
                #insert into database
                insert_into_table(df_can, 'StocksCANRowBased')
                insert_into_table(df_can, 'StocksCANColumnar')
            except Exception as ex:
                print(ex)
                continue
