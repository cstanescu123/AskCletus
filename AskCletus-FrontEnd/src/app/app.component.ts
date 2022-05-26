import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, Observable, switchMap } from 'rxjs';
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

constructor(private _drinkService: DrinkServiceService, private _activatedRoute: ActivatedRoute) {
  this.drink$ = this._drinkService.getRecentDrink();
}

drinkResponse: string = "";

ngOnInit(){
  const subscription = this._drinkService.getRandomDrink().subscribe(response => {
    this.drinkResponse = JSON.stringify(response, null, 2);
  });
}

  toJson(obj: any){
    return JSON.stringify(obj, null, 2);
  }

  //   // PIPING allows us to make a NEW observable from an existing Observable.
  // // Piping allows us to chain operators to our observable. ie, once we get
  // // a subscribed data in, we can "PIPE" the data through operators IN ORDER (order matters)
  // student$ = this._activatedRoute.paramMap.pipe( // we get the param maps then send it down the pipeline
  //   map(params => params.get('id')), // map the params to get the id 
  //   filter(id => id !== null), // we filter so we ONLY get a valid id from the route
  //   map(id => parseInt(id as string, 10)), // convert our id into a number
  //   switchMap((id: number) => this._drinkService.getRandomDrink(id)), // we make an http Request, once that observable is resolved...
  // )// we reach the end of the pipeline, anyone subcribing to this, will get the student data
  // // Observables will ONLY ACT if there is a subscriber

}