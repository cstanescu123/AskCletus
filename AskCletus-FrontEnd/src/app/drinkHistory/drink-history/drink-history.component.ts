import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HistoryResponse } from 'src/app/models/HistoryResponse';
import { HistoryService } from 'src/app/Services/history.service';

@Component({
  selector: 'app-drink-history',
  templateUrl: './drink-history.component.html',
  styleUrls: ['./drink-history.component.css']
})
export class DrinkHistoryComponent implements OnInit {
  
  histories: HistoryResponse[] = []

  constructor(private _historyrService: HistoryService) { }
 
  ngOnInit(): void {
    this._historyrService.getHistories().subscribe(history => {
      this.histories = history;
    })
  }

}
