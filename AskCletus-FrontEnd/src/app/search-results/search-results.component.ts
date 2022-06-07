import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.css'],
})
export class SearchResultsComponent implements OnInit {
  constructor(
    private _activatedRoute: ActivatedRoute,
    private _drinkService: DrinkServiceService
  ) {}

  drink$ = this._activatedRoute.paramMap.pipe(
    map((params) => params.get('id')),
    filter((id) => id !== null),
    map((id) => parseInt(id as string, 10)),
    switchMap((id: number) => this._drinkService.getDrinkById(id))
  );

  ngOnInit(): void {}
}
