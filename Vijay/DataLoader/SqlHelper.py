import pyodbc as pc

sqlConnection_string = (
    "Driver={ODBC Driver 17 for SQL Server};"
    # "Server=DESKTOP-2FHQ4QU;"
    #"Server=DCAS2024JAN\SQLEXPRESS;"
    "Server=localhost"
    "Database=StockReporting;"
    "Trusted_Connection=yes;"




)

def insert_into_table(df, table_name):
    conn = pc.connect(sqlConnection_string)
    cursor = conn.cursor()
    query = 'insert into [dbo].['+table_name+']({0}) values ({1})'
    query = query.format(','.join('[' + df.columns + ']'), ','.join('?' * len(df.columns)))
    cursor.fast_executemany = True
    cursor.executemany(query, df.values.tolist())
    conn.commit()
    conn.close()
