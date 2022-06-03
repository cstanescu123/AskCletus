import { Component, OnInit } from '@angular/core';
import { switchMap } from 'rxjs';
import { IngredientsResponse } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from '../../Services/user-bar-service.service';

@Component({
  selector: 'app-bar-home',
  templateUrl: './bar-home.component.html',
  styleUrls: ['./bar-home.component.css']
})
export class BarHomeComponent implements OnInit {
  
  bars: IngredientsResponse[] = []

  constructor(private _userBarService: UserBarServiceService,
              private _authService: AuthService) { }

              //grab user to get userId to get their version of the bar
              //if no user, don't stay on this page
              //if user get userId for user bar
 
  ngOnInit(): void {
    this._userBarService.getUserBars().subscribe(bars => {
      this.bars = bars;
    })
  }

  removeIngredient(id: number) {
    const userBars$ = this._userBarService.deleteIngredient(id).pipe(
      switchMap(() => this._userBarService.getUserBars())
      );
      userBars$.subscribe(ingredient => {
      this.bars = ingredient
    });
  }
}
