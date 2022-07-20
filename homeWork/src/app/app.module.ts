import { HttpClient, HttpClientModule,HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{AuthorizationService} from './services/authorization.service';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompanyService } from './services/company.service';
import { CompanyComponent } from './company/company.component';
import { EmployeesComponent } from './employees/employees.component';
import { ChartModule } from 'node_modules/primeng/chart';

@NgModule({
  declarations: [
    AppComponent,
    CompanyComponent,
    EmployeesComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
   ChartModule
  ],
  providers: [CompanyService,{provide:HTTP_INTERCEPTORS,useClass:AuthorizationService,multi:true}],
  bootstrap: [AppComponent,HttpClient]
})
export class AppModule { }
