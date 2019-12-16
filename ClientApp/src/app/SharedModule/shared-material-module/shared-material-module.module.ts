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
  MatChipsModule,
  MatTooltipModule} from '@angular/material';

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
    MatChipsModule,
    MatTooltipModule

    
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
    MatChipsModule,
    MatTooltipModule
  
  ]
})
export class SharedMaterialModuleModule { }
