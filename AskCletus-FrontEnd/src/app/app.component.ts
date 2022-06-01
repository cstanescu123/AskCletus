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

constructor() {}

  ngOnInit(){
  }
}
