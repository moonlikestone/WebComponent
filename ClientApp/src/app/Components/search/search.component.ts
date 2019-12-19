import { Component, OnInit } from '@angular/core';
import {FlatTreeControl} from '@angular/cdk/tree';
import {MatTreeFlatDataSource, MatTreeFlattener} from '@angular/material/tree';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  
  tags = ['Door', 'Wooden', 'Aluminum', 'Made of glass'];
  removeTag(tagName) {
    this.tags = this.tags.filter(tag => tag !== tagName);
  }

  ngOnInit() {
  }
}