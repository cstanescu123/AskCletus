import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, mergeMap } from 'rxjs';
import { HistoryResponse } from 'src/app/models/HistoryResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { HistoryService } from 'src/app/Services/history.service';

@Component({
  selector: 'app-drink-history',
  templateUrl: './drink-history.component.html',
  styleUrls: ['./drink-history.component.css']
})
export class DrinkHistoryComponent implements OnInit {
  
  histories: HistoryResponse[] = []

  constructor(private _historyrService: HistoryService,
              private _authService: AuthService) { }
 
  userHistory$ = this._authService.user$.pipe(
    filter(x => x !== null),
    map(x => x!.userId),
    mergeMap(x => this._historyrService.getHistory(x))
  );

  ngOnInit(): void {
    this._historyrService.getHistories().subscribe(history => {
      this.histories = history;
    })
  }
}
