import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './Components/main/main.component';
import { SearchComponent } from './Components/search/search.component';
import { UserInfoComponent } from './Components/user-info/user-info.component';
import { ManufacturerInfoComponent } from './Components/manufacturer-info/manufacturer-info.component';
import { ManagerInfoComponent } from './Components/manager-info/manager-info.component';


const routes: Routes = [
  {path: '', component: MainComponent},
  {path: 'search', component: SearchComponent},
  {path: 'user', component: UserInfoComponent},
  {path: 'manufacturer', component:ManufacturerInfoComponent},
  {path: 'manager', component: ManagerInfoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
