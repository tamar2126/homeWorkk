import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../models/employee.model';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
companyId:number = 0;
employees:Employee[] = [];
data: any;
display:boolean = false;
  constructor( private route:ActivatedRoute, private _service:EmployeesService) { 
    
     
  }
  displayEmployees(){
    this._service.allEmployee(this.companyId).subscribe(d=>this.employees=d);
this.display=true;
  }
  ngOnInit(): void {
    this.route.params.subscribe((params:any) => {
      this.companyId=params.companyId;
      this.display=false;
    this._service.numOfEmployeeAtMonth(this.companyId).subscribe(res=>{     
      this.data = {
        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July','August', 'September', 'October', 'November', 'December'],
        datasets: [
            {
                label: 'number of employees',
                backgroundColor: '#FFA726',
                data: res
            }
        ]
    } 
    });
  });
  }


}
