import { TestBed } from '@angular/core/testing';

import { LoginDiaService } from './login-dia.service';

describe('LoginDiaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LoginDiaService = TestBed.get(LoginDiaService);
    expect(service).toBeTruthy();
  });
});
