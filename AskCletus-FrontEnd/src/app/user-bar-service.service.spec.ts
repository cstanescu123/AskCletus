import { TestBed } from '@angular/core/testing';

import { UserBarServiceService } from './user-bar-service.service';

describe('UserBarServiceService', () => {
  let service: UserBarServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserBarServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
