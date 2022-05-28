import { Component, OnInit } from '@angular/core';
import { IngredientsResponse } from 'src/app/models/IngredientsResponse';
import { UserBarServiceService } from '../../Services/user-bar-service.service';

@Component({
  selector: 'app-bar-home',
  templateUrl: './bar-home.component.html',
  styleUrls: ['./bar-home.component.css']
})
export class BarHomeComponent implements OnInit {
  
  allBars$ = this._userBarService.getUserBars();

  bars: IngredientsResponse[] = []

  constructor(private _userBarService: UserBarServiceService ) { }
 
  ngOnInit(): void {
    this._userBarService.getUserBars().subscribe(bars => {
      this.bars = bars;
    })
  }
}
