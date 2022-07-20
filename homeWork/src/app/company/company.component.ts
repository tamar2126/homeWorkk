import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeesComponent } from '../employees/employees.component';
import { Company } from '../models/company.model';
import { CompanyService } from '../services/company.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
companies: Company[] =[];
  constructor(private _router: Router, private _service:CompanyService) { }

  ngOnInit(): void {
    this._service.allCompanies().subscribe(data => {this.companies=data});
  }
  chartOfCompany(id:number):void {
    this._router.navigate(['/employees',id]);
  }
}
