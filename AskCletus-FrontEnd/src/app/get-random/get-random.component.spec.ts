import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchFunctionsComponent } from './get-random.component';

describe('SearchFunctionsComponent', () => {
  let component: SearchFunctionsComponent;
  let fixture: ComponentFixture<SearchFunctionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchFunctionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchFunctionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
