import { Component, OnInit } from '@angular/core';
import { manufacturer } from "./manufacturer";
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-manufacturer-info',
  templateUrl: './manufacturer-info.component.html',
  styleUrls: ['./manufacturer-info.component.css']
})
export class ManufacturerInfoComponent implements OnInit {
  manufacturer: manufacturer = {
    username: "Bowater Doors",
    email: 'bowaterdoors@birtleygroup.co.uk',
    phonenumber: '0845-121-5376'
  };

  constructor(public snackBar: MatSnackBar) { }
  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
       duration: 2000,
      });
    } 
  
  ngOnInit() {
  }

}
