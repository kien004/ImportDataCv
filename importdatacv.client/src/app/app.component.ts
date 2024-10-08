import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgxPaginationModule } from 'ngx-pagination'; // Import module phân trang
import * as XLSX from 'xlsx';
interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface Contact {
  ContactName: string | null;
  MobilePhone: string | null;
  Email: string | null;
  Hashtag: string | null;
}
interface ColumnMapping {
  fieldName: string;
  columnIndex: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public forecasts: WeatherForecast[] = [];
  public dataImportCV: Contact[] = [];
  public fileName: string = '';
  public p: number = 1; // Trang hiện tại
  public totalItems: number = 0; // Tổng số bản ghi
  public totalPages: number = 0; // Tổng số trang
  public itemsPerPage: number = 1000; // Số bản ghi mỗi trang
  public columnMappings: ColumnMapping[] = []; // Khai báo thuộc tính columnMapping
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getForecasts();
  }

  getForecasts() {
    this.http.get<WeatherForecast[]>('/weatherforecast').subscribe(
      (result) => {
        this.forecasts = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  onFileChange(event: any) {
    const file = event.target.files[0];
    this.fileName = file.name;
    const reader = new FileReader();

    reader.onload = (e: any) => {
      const data = e.target.result;
      const workbook = XLSX.read(data, { type: 'binary' });
      const sheetName = workbook.SheetNames[0];
      const worksheet = workbook.Sheets[sheetName];
      const json = XLSX.utils.sheet_to_json<any>(worksheet, { header: 1 });

      const headerRow = json[0];
      const columnIndices: { [key: string]: number } = {};
      headerRow.forEach((columnName: string, index: number) => {
        switch (columnName) {
          case 'Họ Tên': columnIndices['CONTACT_NAME'] = index; break;
          case 'Số điện thoại': columnIndices['MOBILE_PHONE'] = index; break;
          case 'Email': columnIndices['EMAIL'] = index; break;
          case 'Tên CDTD': columnIndices['HASHTAG'] = index; break;
          case 'Nguồn': columnIndices['SOURCE'] = index; break;
        }
      });

      this.dataImportCV = json.slice(1).map((row: any[]) => ({
        ContactName: row[columnIndices['CONTACT_NAME']] || null,
        MobilePhone: row[columnIndices['MOBILE_PHONE']] ? row[columnIndices['MOBILE_PHONE']].toString() : null, // Chuyển đổi số thành chuỗi
        Email: row[columnIndices['EMAIL']] ? String(row[columnIndices['EMAIL']]) : null, // Đảm bảo kiểu string
        Hashtag: (row[columnIndices['HASHTAG']] ? row[columnIndices['HASHTAG']] as string : '') +
          (row[columnIndices['SOURCE']] ? ', ' + (row[columnIndices['SOURCE']] as string) : ''),
      }));

      this.totalItems = this.dataImportCV.length; // Cập nhật tổng số bản ghi
      this.totalPages = Math.ceil(this.totalItems / this.itemsPerPage); // Cập nhật số trang
    };

    reader.readAsBinaryString(file);

  }

  //excelDateToJSDate(excelDate: number): Date | null {
  //  if (!excelDate) return null;
  //  const jsDate = new Date((excelDate - 25569) * 86400 * 1000);
  //  return jsDate;
  //}

  //excelDateToJSDate(excelDate: any): Date | null {
  //  if (typeof excelDate === 'number') {
  //    // Xử lý trường hợp dữ liệu là số
  //    const jsDate = new Date((excelDate - 25569) * 86400 * 1000);
  //    return jsDate;
  //  } else if (typeof excelDate === 'string') {
  //    // Xử lý trường hợp dữ liệu là chuỗi
  //    const jsDate = new Date(excelDate);
  //    return isNaN(jsDate.getTime()) ? null : jsDate;
  //  }
  //  return null;
  //}

  //formatDate(date: Date | null): string | null {
  //  if (!date) return null;
  //  const day = ('0' + date.getDate()).slice(-2);
  //  const month = ('0' + (date.getMonth() + 1)).slice(-2); // Tháng bắt đầu từ 0
  //  const year = date.getFullYear();
  //  return `${year}-${month}-${day}`;
  //}

  //formatDate(date: Date | null): string | null {
  //  if (!date) return null;
  //  const day = ('0' + date.getDate()).slice(-2);
  //  const month = ('0' + (date.getMonth() + 1)).slice(-2); // Tháng bắt đầu từ 0
  //  const year = date.getFullYear();
  //  return `${year}-${month}-${day}`;
  //}

  saveToDatabase() {
    const MAX_LENGTH = {
      ContactName: 50,  // Độ dài tối đa cho ContactName
      MobilePhone: 100,   // Độ dài tối đa cho MobilePhone
      Email: 100         // Độ dài tối đa cho Email
    };

    const validData = this.dataImportCV.filter((contact) => {
      return (
        (!contact.ContactName || contact.ContactName.length <= MAX_LENGTH.ContactName) &&
        (!contact.MobilePhone || contact.MobilePhone.length <= MAX_LENGTH.MobilePhone) &&
        (!contact.Email || contact.Email.length <= MAX_LENGTH.Email)
      );
    });

    if (validData.length === 0) {
      console.warn('Không có dữ liệu hợp lệ để lưu');
      return;
    }

    this.http.post('https://localhost:7131/api/SmartWord/save', validData).subscribe(
      (response) => {
        console.log('Dữ liệu đã được lưu thành công:', response);
      },
      (error) => {
        console.error('Có lỗi xảy ra khi lưu dữ liệu', error);
      }
    );
  }
}
