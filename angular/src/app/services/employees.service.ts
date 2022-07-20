import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../models/employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  constructor(private _http:HttpClient) { }
  allEmployee(companyId:number): Observable<Employee[]> {
    return this._http.post<Employee[]>("/api/employee/allEmployee",companyId);
  }
  numOfEmployeeAtMonth(companyId:number): Observable<number[]> {
    return this._http.post<number[]>("/api/employee/numOfEmployeeAtMonth",companyId);
  }
}
