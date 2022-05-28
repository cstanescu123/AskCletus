import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, Observable, switchMap } from 'rxjs';
import { Drink, DrinkResponse } from './models/DrinkResponse';
import { IngredientsResponse } from './models/IngredientsResponse';
import { DrinkServiceService } from './Services/drink-service.service';
import { UserBarServiceService } from './Services/user-bar-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'AskCletus-FrontEnd';

  drink$: Observable<DrinkResponse>;
  
  userBars$ = this._userBarService.getUserBars();
  bars: IngredientsResponse[] = [];

  

constructor(private _drinkService: DrinkServiceService, 
            private _activatedRoute: ActivatedRoute,
            private _userBarService: UserBarServiceService) 
            {
              this.drink$ = this._drinkService.getRecentDrink();
            }

bar$ = this._userBarService.getUserBars();
allBars: IngredientsResponse[] = [];

drinkResponse: string = "";

ngOnInit(){
  // const subscription = this._drinkService.getRandomDrink().subscribe(response => {
  //   this.drinkResponse = JSON.stringify(response, null, 2);
  // });
      this._userBarService.getUserBars().subscribe(allBars => {
      this.allBars = allBars;
    })
  }
  
  toJson(obj: any){
    return JSON.stringify(obj, null, 2);
  }
}
