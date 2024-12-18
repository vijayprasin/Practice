import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StockReportService {

  // private apiUrl = 'https://your-api-url/api/Loader'; // Your API endpoint
  private apiUrl = 'https://localhost:7124/api/StockReports';  // Replace with your actual API endpoint

  constructor(private http: HttpClient) { }

  // Function to upload the file and submit other form data
  uploadFile(formData: FormData): Observable<any> {

    return this.http.post(`${this.apiUrl}/upload`, formData);
  }

  getReports(
    reportSelection: string[],
    fromDate?: Date,
    toDate?: Date,
    columns?: string[]
  ): Observable<any[]> {
    let params = new HttpParams();

    if (reportSelection) {
      // Add report selection
      reportSelection.forEach((report) => {
        params = params.append('reportSelection', report);
      });
    }

    // Add date parameters if they exist
    if (fromDate) {
      const date = new Date(fromDate);
      if (!isNaN(date.getTime())) {
        params = params.append('fromDate', date.toISOString());
      }
    }
    if (toDate) {
      const date = new Date(toDate);
      if (!isNaN(date.getTime())) {
        params = params.append('toDate', date.toISOString());
      }
    }

    // Add columns parameter as a comma-separated string if provided
    if (columns && columns.length > 0) {
      // params = params.append('columns', columns.join(','));

      columns.forEach((column) => {
        params = params.append('columns', column);
      });
    }

    return this.http.get<any[]>(`${this.apiUrl}/reports`, { params });
  }
}
