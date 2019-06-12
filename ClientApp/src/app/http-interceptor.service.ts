import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HttpInterceptorService implements HttpInterceptor {

  constructor() { }

  public intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>>{
    const newRequest = req.clone({url: `https://localhost:5001/${req.url}`});
    return next.handle(req).pipe(
      catchError((error: HttpErrorResponse)=>{
        console.log(error);
        throwError(error);
        return of(null);
      })
    )
  }
}
