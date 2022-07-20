import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Company} from '../models/company.model'

@Injectable(
 
)
export class CompanyService {

  constructor(private _http:HttpClient) { }
  allCompanies(): Observable<Company[]> {
    return this._http.post<Company[]>("/api/company/allCompany",null);
  }
}
