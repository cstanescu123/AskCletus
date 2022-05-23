import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';
import { HistoryService } from 'src/app/history.service';

@Component({
  selector: 'app-drink-history',
  templateUrl: './drink-history.component.html',
  styleUrls: ['./drink-history.component.css']
})
export class DrinkHistoryComponent implements OnInit {

  constructor(

    private _activatedRoute: ActivatedRoute,
    private _historyService: HistoryService

  ) { }
  ngOnInit(): void {

  }


   drinkHistory$ = this._activatedRoute.paramMap.pipe(
    map(params => params.get('historyId')), 
    filter(historyId => historyId !== null), 
    map(historyId => parseInt(historyId as string, 10)),
    switchMap((historyId: number) => this._historyService.getHistory(historyId)),)


}
