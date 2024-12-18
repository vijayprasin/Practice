
Project Setup Instructions for Mac
1. Download Input Files
Download the input files for USA and Canada and extract them to a location of your choice.
2. Download DataLoader Scripts
Download the DataLoader Python scripts and extract them to a location of your choice.

3. Ensure Python 3.12 or Above is Installed
Check Python installation: python3 --version

If Python 3.12 or above is not installed, install it via Homebrew: brew install python

4. Set Up Python Environment
Open the Terminal and navigate to your Python installation directory (if needed): Example:/usr/local/bin/python3

5. Install Required Packages
Use pip to install the required packages: pip3 install pyodbc pandas
If pip is not recognized, ensure it's installed with: python3 -m ensurepip --upgrade
If you encounter issues, verify your PATH includes Python scripts: Export PATH=$PATH:/Library/Frameworks/Python.framework/Versions/3.x/bin

6. Update Loader.py File
Open the Loader.py file from the DataLoader folder in a text editor (e.g., VS Code).
Update the input paths for the USA and Canada, replacing them with your local paths. Use forward slashes (/) for Mac: dir_path_usa = '/Users/vijay/Desktop/Vijay/USA/'
dir_path_can = '/Users/vijay/Desktop/Vijay/Canada/'


7. Update SqlHelper.py File
Open the SqlHelper.py file and update the server name at line 6 with your database server details: server = 'localhost'  

8. Update appsettings.json
Open the Visual Studio solution and navigate to appsettings.json.
Update the connection string to match your local SQL server. Example:  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyAppDb;User Id=sa;Password=MyStrongPass123;"
}

9. Update MYAppDbContext.cs
Open the MYAppDbContext.cs file under the Model folder and update the server name at line 22: optionsBuilder.UseSqlServer("Server=localhost;Database=MyAppDb;User Id=sa;Password=MyStrongPass123;");


10. Update StockReportRepository.cs
Open StockReportRepository.cs and make the following changes:
Update line 41 with the Python interpreter path: string pythonInterpreter = @"/usr/local/bin/python3";
Update line 47 with your loader.py path: string scriptPath = @"/Users/vijay/Desktop/Vijay/DataLoader/Loader.py";

11. UI Setup
To set up and run the Angular application:
1. Install Node.js: brew install node
2. Install Angular CLI: npm install -g @angular/cli
3. Set Execution Policy (Mac doesn’t require PowerShell commands like Windows).
4. Install Required Python Packages:
pip3 install pyodbc numpy pandas
5. Run Angular Application:
Navigate to the Angular project directory: cd stockreport.client
Install dependencies: npm install
Build and serve the Angular application: ng build
ng serve
Open the provided URL in your browser (usually http://localhost:4200).


