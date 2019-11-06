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
  MatListModule} from '@angular/material';

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
    MatListModule

    
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
    MatListModule
  
  ]
})
export class SharedMaterialModuleModule { }
