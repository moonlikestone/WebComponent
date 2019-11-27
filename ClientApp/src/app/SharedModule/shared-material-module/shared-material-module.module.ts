import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatButtonModule, 
  MatToolbarModule,
  MatDialogModule,
  MatFormFieldModule,
  MatIconModule,
  MatInputModule, 
  MatGridListModule,
  MatCard,
  MatCardModule,
  MatNavList,
  MatListModule,
  MatSnackBarModule,
  MatTabsModule,
  MatChipsModule} from '@angular/material';

  import { MatMenuModule} from '@angular/material/menu';

@NgModule({
  declarations: [],
  imports: [
    MatButtonModule, 
    MatToolbarModule,
    MatDialogModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    MatMenuModule,
    MatGridListModule,
    MatCardModule,
    MatListModule,
    MatSnackBarModule,
    MatTabsModule,
    MatChipsModule

    
  ],
  exports:[
    MatButtonModule,
    MatToolbarModule,
    MatDialogModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    MatMenuModule,
    MatGridListModule,
    MatCardModule,
    MatListModule,
    MatSnackBarModule,
    MatTabsModule,
    MatChipsModule
  
  ]
})
export class SharedMaterialModuleModule { }
