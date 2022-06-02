import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetDrinkNameComponent } from './get-drink-name.component';

describe('GetDrinkNameComponent', () => {
  let component: GetDrinkNameComponent;
  let fixture: ComponentFixture<GetDrinkNameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetDrinkNameComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetDrinkNameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
