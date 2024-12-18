import { TestBed } from '@angular/core/testing';

import { StockReportService } from './stockReport.service';

describe('StockReportService', () => {
  let service: StockReportService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StockReportService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
