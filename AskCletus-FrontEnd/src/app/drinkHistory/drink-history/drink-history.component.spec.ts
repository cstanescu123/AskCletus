import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DrinkHistoryComponent } from './drink-history.component';

describe('DrinkHistoryComponent', () => {
  let component: DrinkHistoryComponent;
  let fixture: ComponentFixture<DrinkHistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DrinkHistoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DrinkHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
