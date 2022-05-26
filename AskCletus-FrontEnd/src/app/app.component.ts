import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Drink, DrinkResponse } from './models/DrinkResponse';
import { DrinkServiceService } from './Services/drink-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'AskCletus-FrontEnd';

  drink$: Observable<DrinkResponse>;

constructor(private _drinkService: DrinkServiceService) {
  this.drink$ = this._drinkService.getRecentDrink();
}

drinkResponse: string = "";

ngOnInit(){
  const subscription = this._drinkService.getRecentDrink().subscribe(response => {
    this.drinkResponse = JSON.stringify(response, null, 2);
  });
}

  toJson(obj: any){
    return JSON.stringify(obj, null, 2);
  }
}