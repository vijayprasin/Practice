import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { StockReportService } from '../services/stockReport.service';
import { CommonModule } from '@angular/common';

interface FormField {
  name: string;
  type: string; // e.g., 'text', 'radio', 'select', etc.
  controlName: string;
  options?: { label: string; value: string }[]; // For select/radio options
  placeholder?: string; // For text inputs
}

@Component({
  selector: 'app-report-dashboard',
  standalone: true,
  imports: [ReactiveFormsModule, NgSelectModule,CommonModule],
  templateUrl: './report-dashboard.component.html',
  styleUrl: './report-dashboard.component.scss',
  encapsulation: ViewEncapsulation.None
})
export class ReportDashboardComponent implements OnInit {
  reportForm!: FormGroup;
  selectedFile: File | null = null;
  isFileValid: boolean = false;

  // Define your dynamic form fields here
  dynamicFormFields: FormField[] = [
    {
      name: 'Country', type: 'radio', controlName: 'country', options: [
        { label: 'USA', value: 'USA' },
        { label: 'India', value: 'India' },
        { label: 'Canada', value: 'Canada' }
      ]
    },
    {
      name: 'Database', type: 'radio', controlName: 'database', options: [
        { label: 'SQL Server', value: 'SqlServer' },
        { label: 'Oracle', value: 'Oracle' },
        { label: 'PostgreSql', value: 'PostgreSql' },
        { label: 'MySQL', value: 'MySql' },
        { label: 'MariaDb', value: 'MariaDb' },
        { label: 'MongoDb', value: 'MongoDb' },
        { label: 'CosmosDb', value: 'CosmosDb' }
      ]
    },
    { name: 'Database Name', type: 'text', controlName: 'databaseName', placeholder: 'Enter Database Name' },
    { name: 'Table Name', type: 'text', controlName: 'tableName', placeholder: 'Enter Table Name' },
    {
      name: 'Table Type', type: 'radio', controlName: 'tableType', options: [
        { label: 'Row-Based', value: 'RowBased' },
        { label: 'Column-Based', value: 'ColumnBased' }
      ]
    },
    {
      name: 'Upload File',
      type: 'file',
      controlName: 'uploadedFile',
      placeholder: 'Choose a file to upload'
    },
    {
      name: 'Select Symbols',
      type: 'multi-select',
      controlName: 'reportSelection',
      options: []
    },

    // Date Range with From and To fields
    { name: 'From Date', type: 'date', controlName: 'fromDate', placeholder: 'Select From Date' },
    { name: 'To Date', type: 'date', controlName: 'toDate', placeholder: 'Select To Date' },
    {
      name: 'Select Columns', type: 'multi-select', controlName: 'columns', options: []
    },
    {
      name: 'Report Type', type: 'radio', controlName: 'reportType', options: [
        { label: 'CSV', value: 'CSV' },
        { label: 'XLS', value: 'XLS' },
        { label: 'Both CSV/XLS', value: 'both' }
      ]
    }
  ];

  columns=[];
  stockreports=[];

  constructor(private fb: FormBuilder, private stockReportService: StockReportService) { }

  ngOnInit(): void {
    this.createDynamicForm();
    this.reportForm = this.fb.group({
      country: ['USA'],
      database: ['SqlServer'],
      tableType: ['RowBased'],
      databaseName: [''],
      tableName: [''],
      reportSelection: [''],
      fromDate: [''],
      toDate: [''],
      columns: [''],
      reportType: ['CSV'],
      uploadedFile: ['']
    });
  }

  createDynamicForm() {
    const formGroup: { [key: string]: any } = {};

    this.dynamicFormFields.forEach(field => {
      if (field.type === 'select' || field.type === 'radio') {
        formGroup[field.controlName] = ['']; // Initial value for select/radio
      } else {
        formGroup[field.controlName] = ['']; // Initial value for text/date inputs
      }
    });

    this.reportForm = this.fb.group(formGroup);
  }

  onFileSelected(event: any): void {
    const file: File = event.target.files[0];
    const allowedTypes = ['text/csv', 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet', 'text/plain'];

    // Validate file type
    if (file && allowedTypes.includes(file.type)) {
      this.isFileValid = true;
      this.selectedFile = file;  // Store file in the variable
    } else {
      this.isFileValid = false;
      this.selectedFile = null;  // Clear the file if invalid
      alert('Invalid file type. Please select a valid .csv, .xlsx, or .txt file.');
    }
  }

  uploadFile() {
    if (this.isFileValid && this.selectedFile) {
      const formData = new FormData();

      // Append form fields
      formData.append('Country', this.reportForm.get('country')?.value);
      formData.append('Database', this.reportForm.get('database')?.value);
      formData.append('DatabaseName', this.reportForm.get('databaseName')?.value);
      formData.append('TableName', this.reportForm.get('tableName')?.value);
      formData.append('TableType', this.reportForm.get('tableType')?.value);

      // Append file to FormData
      formData.append('UploadedFile', this.selectedFile, this.selectedFile.name);
      // Send the form data to the service
      this.stockReportService.uploadFile(formData).subscribe({
        next: (response:any) => {
          alert("File Uploaded Sucessfully");
          this.reportForm.get('reportSelection')?.setValue('');
          if (response?.reportSelections) {
            const updatedOptions = response.reportSelections.map((item: any) => ({
              label: item,
              value: item
            }));

            // Find the field to update
            const reportField = this.dynamicFormFields.find(field => field.controlName === 'reportSelection');
            if (reportField) {
              reportField.options = updatedOptions;  // Update the options
            }
          }

          this.reportForm.get('columns')?.setValue('');
          if(response?.columns){
            this.columns = response.columns.map((col: string) => col.toLowerCase());
            
            const updatedColOptions = response.columns.map((item: any) => ({
              label: item,
              value: item
            }));

            // Find the field to update
            const columnField = this.dynamicFormFields.find(field => field.controlName === 'columns');
            if (columnField) {
              columnField.options = updatedColOptions;  // Update the options
            }
          }
        },
        error: (err:Error) => {
          alert("Error uploading file");
          console.error('Error uploading file', err);
        }
      });
    } else {
      console.log('No file selected');
    }
  }

  generateReport() {
    this.stockReportService
    .getReports(this.reportForm.get('reportSelection')?.value, this.reportForm.get('fromDate')?.value, this.reportForm.get('toDate')?.value, this.reportForm.get('columns')?.value)
    .subscribe(
      (data:any) => {
        alert("Report Generated Sucessfully")
        this.stockreports = data; // Assign the fetched data to reports
      },
      (error:Error) => {
        alert('Error fetching reports');
        console.error('Error fetching reports', error); // Handle error
      }
    );

  }
}
