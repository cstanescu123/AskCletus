import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import {
  debounceTime,
  distinctUntilChanged,
  map,
  Observable,
  switchMap,
} from 'rxjs';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-drink-ingredient',
  templateUrl: './get-drink-ingredient.component.html',
  styleUrls: ['./get-drink-ingredient.component.css'],
})
export class GetDrinkIngredientComponent implements OnInit {
  constructor(private _drinkService: DrinkServiceService) {
    this.drinkNameControl = new FormControl();
    this.drinkInput$ = this.drinkNameControl.valueChanges;
    this.drinks$ = this.drinkInput$.pipe(
      debounceTime(500),
      distinctUntilChanged(),
      switchMap((x) => this._drinkService.getDrinkByIngredient(x)),
      map((x) => x.drinks)
    );
  }
  drinkNameControl: FormControl;
  drinks$: Observable<any>;
  drinkInput$: Observable<string>;
  ngOnInit(): void {}
}
