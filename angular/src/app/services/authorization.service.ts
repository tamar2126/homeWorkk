import { HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService implements HttpInterceptor {

  constructor() { }
  intercept(req:HttpRequest<any>,next:HttpHandler){
 //   const token=req.clone({
//headers:req.headers.set('Authorization',"1234")
  //  })
   const request = req.clone({
      setHeaders: {
        'Authorization': "1234",
        'Content-Type': "application/json"
      }
    });
    

    return next.handle(request);

  
  }
}
