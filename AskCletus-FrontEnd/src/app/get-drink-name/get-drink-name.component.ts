import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { mergeMap, Observable } from 'rxjs';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-drink-name',
  templateUrl: './get-drink-name.component.html',
  styleUrls: ['./get-drink-name.component.css']
})
export class GetDrinkNameComponent implements OnInit {

  constructor(private _drinkService: DrinkServiceService) { 
  }
  
  ngOnInit(): void {
  }

}
