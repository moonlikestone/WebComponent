import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoginDiaService {

  constructor(private http: HttpClient) { }

  private extractData(res: Response){
    if(res.status < 200 || res.status>= 300){
      throw new Error('Bad response status:' + res.status);
    }
    let body = JSON.stringify(res);
    return body || {};
  }

  checkAccount(account:string, password: string){
    return this.http.post("https://localhost:5001/api/Member/CheckAccount", { Account: account, Password: password })
    .pipe(map(data=> JSON.stringify(data)));
  }
  updateLogTime(account:string){
    return this.http.post("https://localhost:5001/api/Members/UpdateLogTime", {Account: account})
    .pipe(map(data => JSON.stringify(data)));
  }
}
