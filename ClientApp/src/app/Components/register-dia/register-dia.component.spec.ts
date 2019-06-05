import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterDiaComponent } from './register-dia.component';

describe('RegisterDiaComponent', () => {
  let component: RegisterDiaComponent;
  let fixture: ComponentFixture<RegisterDiaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegisterDiaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterDiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
