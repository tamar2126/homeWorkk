export class Employee {
     Id :number;
    CompanyEmployeeId :number;
    StartWorkDate:Date;
    EndWorkDate:Date;
    EmplooyeName:string;
constructor(emplooyeName:string, id:number,startWorkDate:Date,endWorkDate:Date,companyEmployeeId:number) {
 this.EmplooyeName = emplooyeName;
 this.Id = id;
 this.CompanyEmployeeId=companyEmployeeId;
 this.StartWorkDate= startWorkDate;
 this.EndWorkDate= endWorkDate; 
    
}
}
