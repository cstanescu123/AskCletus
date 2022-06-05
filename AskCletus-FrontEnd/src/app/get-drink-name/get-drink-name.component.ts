import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { DrinkResponse } from '../models/DrinkResponse';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-drink-name',
  templateUrl: './get-drink-name.component.html',
  styleUrls: ['./get-drink-name.component.css']
})
export class GetDrinkNameComponent implements OnInit {


  constructor(private _drinkService : DrinkServiceService) { 

  }

  ngOnInit(): void {
  }

}
