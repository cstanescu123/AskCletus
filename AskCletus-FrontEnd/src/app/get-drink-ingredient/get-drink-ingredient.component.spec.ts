import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetDrinkIngredientComponent } from './get-drink-ingredient.component';

describe('GetDrinkIngredientComponent', () => {
  let component: GetDrinkIngredientComponent;
  let fixture: ComponentFixture<GetDrinkIngredientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetDrinkIngredientComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetDrinkIngredientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
