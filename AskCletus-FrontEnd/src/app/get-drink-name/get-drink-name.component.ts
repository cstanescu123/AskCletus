import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { map, mergeMap, Observable, pipe, switchMap } from 'rxjs';
import { DrinkResponse } from '../models/DrinkResponse';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-drink-name',
  templateUrl: './get-drink-name.component.html',
  styleUrls: ['./get-drink-name.component.css']
})
export class GetDrinkNameComponent implements OnInit {

  constructor(private _drinkService: DrinkServiceService) { 
    this.drinkNameControl = new FormControl();
    this.drinkInput$ = this.drinkNameControl.valueChanges;
    this.drinkName$ = this.drinkInput$.pipe(
      switchMap(x => this._drinkService.getDrinkByName(x)),
      map(x => x.drinks)
    );
  }
  drinkNameControl: FormControl;
  drinkName$: Observable<any>;
  drinkInput$: Observable<string>;
  ngOnInit(): void { }
}
