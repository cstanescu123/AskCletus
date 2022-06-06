import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import {
  debounce,
  debounceTime,
  distinctUntilChanged,
  map,
  mergeMap,
  Observable,
  pipe,
  switchMap,
} from 'rxjs';
import { DrinkResponse } from '../models/DrinkResponse';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-drink-name',
  templateUrl: './get-drink-name.component.html',
  styleUrls: ['./get-drink-name.component.css'],
})
export class GetDrinkNameComponent implements OnInit {
  constructor(private _drinkService: DrinkServiceService) {
    this.drinkNameControl = new FormControl();
    this.drinkInput$ = this.drinkNameControl.valueChanges;
    this.drinks$ = this.drinkInput$.pipe(
      debounceTime(500),
      distinctUntilChanged(),
      switchMap((x) => this._drinkService.getDrinkByName(x)),
      map((x) => x.drinks)
    );
  }
  drinkNameControl: FormControl;
  drinks$: Observable<any>;
  drinkInput$: Observable<string>;
  ngOnInit(): void {}
}
