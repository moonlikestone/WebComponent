import { Component, OnInit } from '@angular/core';
import {FlatTreeControl} from '@angular/cdk/tree';
import {MatTreeFlatDataSource, MatTreeFlattener} from '@angular/material/tree';

@Component({
  selector: 'app-manager-info',
  templateUrl: './manager-info.component.html',
  styleUrls: ['./manager-info.component.css']
})
export class ManagerInfoComponent implements OnInit {

  ngOnInit() {
  }

  private _transformer = (node: FoodNode, level: number) => {
    return {
      expandable: !!node.children && node.children.length > 0,
      name: node.name,
      level: level,
    };
  }

  treeControl = new FlatTreeControl<ExampleFlatNode>(
      node => node.level, node => node.expandable);

  treeFlattener = new MatTreeFlattener(
      this._transformer, node => node.level, node => node.expandable, node => node.children);

  dataSource = new MatTreeFlatDataSource(this.treeControl, this.treeFlattener);

  constructor() {
    this.dataSource.data = TREE_DATA;
  }

  hasChild = (_: number, node: ExampleFlatNode) => node.expandable;
}



interface FoodNode {
  name: string;
  children?: FoodNode[];
}

const TREE_DATA: FoodNode[] = [
  {
    name: '主機服務',
    children: 
    [
      {name: '客戶'},
      {name: '代理商'},
      {name: '域名'},
      {name: '訂閱'},
      {name: '服務方案'},
    ]
  }, 
  {
    name: '伺服器管理',
    children: [
      {name: '工具與設定'},
      {name: '擴展'},
      {name: '信箱'},
      {name: '流量統計'},
      {name: '網頁紀錄分析'},
    ]
  }, 
  {
    name: '我的個人資料',
    children: 
    [
      {name: '偏好設定'},
      {name: '登入紀錄'},
    ]
  }, 
    ];
    
interface ExampleFlatNode 
{
  expandable: boolean;
  name: string;
  level: number;
}
