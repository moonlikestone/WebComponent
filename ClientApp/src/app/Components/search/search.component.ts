import { Component, OnInit } from '@angular/core';
import { user } from  './user';
import { getMatIconFailedToSanitizeLiteralError } from '@angular/material';
@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
   user: user = {
    username: 'alex',
    email: '123456789@gmail.com',
    phonenumber: 75554153
  };


  constructor() { }

  ngOnInit() {
  }

}
