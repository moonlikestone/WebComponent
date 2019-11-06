import { Component, OnInit } from '@angular/core';
import { user } from "./users";
@Component({
  selector: 'app-user-info',
  templateUrl: './user-info.component.html',
  styleUrls: ['./user-info.component.css']
})
export class UserInfoComponent implements OnInit {
  user: user = {
    username: 'alex',
    email: '123456789@gmail.com',
    phonenumber: 123
  };

  constructor() { }

  ngOnInit() {
  }

}
