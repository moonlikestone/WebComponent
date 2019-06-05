import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginDiaComponent } from './login-dia.component';

describe('LoginDiaComponent', () => {
  let component: LoginDiaComponent;
  let fixture: ComponentFixture<LoginDiaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoginDiaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginDiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
