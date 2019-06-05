import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { LoginDiaComponent } from '../login-dia/login-dia.component';
import { RegisterDiaComponent } from '../register-dia/register-dia.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  login = false;
  userName: string;
  logAccount: string;
  ngOnInit() {
  }
  openLogIn(){
    let dialogRef = this.dialog.open(LoginDiaComponent,{
      height: '45%',
      width: '30%'
    });
    dialogRef.afterClosed().subscribe(res =>{
      if(res.IsSuccess){
        this.login = true;
        this.userName = res.Data.FirstName;
        this.logAccount = res.Data.Account;
      }
      else if(res == "Register"){
        let registerDia = this.dialog.open(RegisterDiaComponent,{
          height: '45%',
          width: '30%'
        });
      }
      else{
        this.login = false;
      }
    })
  }
  LogOut(){
    this.login = false;
    this.userName = "";
    this.logAccount = "";
  }
}
