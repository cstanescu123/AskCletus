import { Component, OnInit } from '@angular/core';
import { switchMap } from 'rxjs';
import { UserBarResponse } from 'src/app/models/UserBarResponse';
import { UserBarServiceService } from 'src/app/user-bar-service.service';

@Component({
  selector: 'app-bar-home',
  templateUrl: './bar-home.component.html',
  styleUrls: ['./bar-home.component.css']
})
export class BarHomeComponent implements OnInit {
  
  userBar$ = this._userbarservice.getUserBars();
  
  bars: UserBarResponse[] = [];

  constructor(private _userbarservice: UserBarServiceService) { }

  ngOnInit(): void {
    this._userbarservice.getUserBars().subscribe(userBars => {
      this.bars = userBars;
    })
  }

  deleteIngredient(ingredientsId: number) {
    this._userbarservice.deleteIngredient(ingredientsId).pipe(
      switchMap(() => this._userbarservice.getUserBars())
    ).subscribe(userBars => {
      this.bars = userBars
    });
  }

}
