import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule , ReactiveFormsModule} from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { HttpInterceptorService } from './http-interceptor.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedMaterialModuleModule } from './SharedModule/shared-material-module/shared-material-module.module';
import { NavbarComponent } from './Components/navbar/navbar.component';
import { LoginDiaComponent } from './Components/login-dia/login-dia.component';
import { MAT_LABEL_GLOBAL_OPTIONS, MatMenuModule } from '@angular/material';
import { RegisterDiaComponent } from './Components/register-dia/register-dia.component';
import { MainComponent } from './Components/main/main.component';
import { SearchComponent } from './Components/search/search.component';
import { UserInfoComponent } from './Components/user-info/user-info.component';
import { ManagerInfoComponent } from './Components/manager-info/manager-info.component';
import { ManufacturerInfoComponent } from './Components/manufacturer-info/manufacturer-info.component';
import { from } from 'rxjs';
import {MatTreeModule} from '@angular/material/tree';
import {MatExpansionModule} from '@angular/material/expansion';
import {DragDropModule} from '@angular/cdk/drag-drop';
import {ScrollingModule} from '@angular/cdk/scrolling';
import {CdkTableModule} from '@angular/cdk/table';
import {CdkTreeModule} from '@angular/cdk/tree';
import {MatListModule} from '@angular/material';
import {MatGridListModule} from '@angular/material';
import {MatCardModule} from '@angular/material';
import {MatProgressBarModule} from '@angular/material';
import {LayoutModule} from '@angular/cdk/layout';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginDiaComponent,
    RegisterDiaComponent,
    MainComponent,
    SearchComponent,
    UserInfoComponent,
    ManagerInfoComponent,
    ManufacturerInfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    SharedMaterialModuleModule,
    FormsModule,
    ReactiveFormsModule,
    MatMenuModule,
    MatTreeModule,
    MatExpansionModule,
    DragDropModule,
    ScrollingModule,
    CdkTableModule,
    CdkTreeModule,
    MatListModule,
    MatGridListModule,
    MatCardModule,
    MatProgressBarModule,
    LayoutModule

    
  ],
  providers: [
    {provide: MAT_LABEL_GLOBAL_OPTIONS, useValue: { float: 'auto' }},
    {provide: HTTP_INTERCEPTORS, useClass: HttpInterceptorService, multi: true}
  ],
  bootstrap: [AppComponent],
  entryComponents: [
    LoginDiaComponent,
    RegisterDiaComponent
  ]
})
export class AppModule { }
