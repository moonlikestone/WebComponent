import { Component, OnInit } from '@angular/core';
import { manufacturer } from "./manufacturer";

@Component({
  selector: 'app-manufacturer-info',
  templateUrl: './manufacturer-info.component.html',
  styleUrls: ['./manufacturer-info.component.css']
})
export class ManufacturerInfoComponent implements OnInit {
  manufacturer: manufacturer = {
    username: "bob's componey",
    email: '775556789@gmail.com',
    phonenumber: 156328797
  };

  constructor() { }

  ngOnInit() {
  }

}
