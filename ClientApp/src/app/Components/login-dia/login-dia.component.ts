import { Component, OnInit , Output, EventEmitter } from '@angular/core';
import { LoginDiaService } from './login-dia.service';
import { Observable } from 'rxjs';
import { FormControl } from '@angular/forms';
import { MatDialog , MatDialogRef} from '@angular/material';

@Component({
  selector: 'app-login-dia',
  templateUrl: './login-dia.component.html',
  styleUrls: ['./login-dia.component.css']
})
export class LoginDiaComponent implements OnInit {

  hide = true;
  account : string;
  password : string;
  Checkresult$: Observable<any>;
  AccountControl  = new FormControl('');
  PasswordControl = new FormControl('');
  constructor(private service: LoginDiaService, public dialogRef: MatDialogRef<LoginDiaComponent>) {
   }

  ngOnInit() {
  }

  public ToCheckAccount(){
    this.service.checkAccount(this.account, this.password).subscribe((data)=>{
      var jsonData = JSON.parse(data);
      if(jsonData.IsSuccess == true){
        this.dialogRef.close(jsonData);
        this.PasswordControl.setErrors({valid:true});
        this.AccountControl.setErrors({valid:true});
      }
      else{
        if(jsonData.Message == "Account is invalid!"){
          this.AccountControl.setErrors({valid:false});
        }
        else{
          this.PasswordControl.setErrors({valid:false});
        }
      }
    } );
  }

  public Register(){
    this.dialogRef.close("Register");
  }
}
