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

  constructor(public dialog: MatDialog, ) { }

  login = false;
  userName: string;
  logAccount: string;
  userType: string;
  ngOnInit() {
    //這邊僅供測試不同用戶登入介面
    this.login = true;
    this.userName = "TestPeople";
    this.logAccount = "TestAccount";
    //登入介面會依照userType的不同而有不同
    //user = 一般使用者, manager = 管理人員, manufacturer = 製造商
    this.userType = "manager";
  }
  toMemberInfo(){

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
        this.userType = res.Data.Type;
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
    this.userType = "";
  }
}
