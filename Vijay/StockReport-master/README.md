# StockReport

# Project Setup Instructions

## Changes Needed to Run the Code

1. **Download Input Files**
   - Download the input files for USA/Canada and extract them to a desired location.

2. **Download DataLoader Scripts**
   - Download the DataLoader Python scripts and extract them to a desired location.

3. **Install Python**
   - Ensure Python 3.12 or above is installed on your system.

4. **Set Up Python Environment**
   - Open Command Prompt and navigate to your Python installation directory:
     ```sh
     cd C:\Users\Admin\AppData\Local\Programs\Python\Python313
     ```

5. **Install Required Packages**
   - Run the following commands to install necessary packages:
     ```sh
     pip install pyodbc
     pip install pandas
     ```

   - If you encounter issues with `pip`, you might need to enable the environment variable:

     ### Steps to Enable Environment Variable
     a) Open the System Properties window by pressing `Windows key + R`, typing `sysdm.cpl`, and pressing Enter.
     b) Go to the **Advanced** tab and click on **Environment Variables**.
     c) In the **System variables** section, find the `Path` variable and click **Edit**.
     d) Add the path to your Python Scripts folder (e.g., `C:\Python39\Scripts`).

6. **Update Loader.py File**
   - Open the `Loader.py` file from the DataLoader folder.
   - At lines 6 and 8, replace the input path with your file paths for USA and Canada. Make sure to change backward slashes to forward slashes before pasting.
     ```python
     #dir_path_usa = 'C:/Users/mukil/OneDrive/Documents/Projects/DataEngineering/Input/USA/'
     dir_path_usa = 'C:/Users/Admin/Downloads/USA/'
     #dir_path_can = 'C:/Users/mukil/OneDrive/Documents/Projects/DataEngineering/Input/Canada/'
     dir_path_can = 'C:/Users/Admin/Downloads/Canada/'
     ```

7. **Update SqlHelper File**
   - Open the `SqlHelper` file and replace the server at line 6 with your SSMS server.
     ```csharp
     Server=DESKTOP-xyzs;
     ```

8. **Update appsettings.json**
   - Open the Visual Studio solution and go to `appsettings.json`.
   - Update the connection string with your local server.

9. **Update MYAppDbContext.cs**
   - Open `MYAppDbContext.cs` file under the Model folder.
   - Update the server name at line 22.

10. **Update StockReportRepository.cs**
    - Open `StockReportRepository.cs` file.
    - Change line 41 with your Python path.
      ```csharp
      string pythonInterpreter = @"C:\Users\Admin\AppData\Local\Programs\Python\Python313\python.exe";
      ```

    - Change line 47 with your `loader.py` path.
      ```csharp
      string scriptPath = @"C:\Users\Admin\Downloads\DataLoader\Dat";
      ```


11. **Ui set up** 

Steps to run the angular UI code:

- Install NodeJs Latest version
- Install Angular Js latest version
- Set up environment variable (eg : C:\Users\deepu\AppData\Roaming\npm)
- install python and check python --version in cmd 
- pip --version
- run this in cmd pip install pyodbc
- run this in cmd pip install numpy
- run this in cmd pip install pandas
- Open angular application in visual code. open Terminal. --> Cmd command to check whether angular installed: ng version
- Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned
- run npm install openssl
- run cd stockreport.client 
- ng build
- ng serve -->(click on the given link )
