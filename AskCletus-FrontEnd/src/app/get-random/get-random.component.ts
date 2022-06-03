import { Component, OnInit } from '@angular/core';
import { UntypedFormControl, UntypedFormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { DrinkResponse } from '../models/DrinkResponse';
import { DrinkServiceService } from '../Services/drink-service.service';

@Component({
  selector: 'app-get-random',
  templateUrl: './get-random.component.html',
  styleUrls: ['./get-random.component.css']
})
export class GetRandomComponent implements OnInit {
  randomDrink$: Observable<DrinkResponse>;
  
  constructor
  ( private _drinkService: DrinkServiceService, 
    private _activatedRoute: ActivatedRoute,) { 
      this.randomDrink$ = this._drinkService.getRandomDrink();
    }

    //drinks: DrinkResponse[] = [];

    drinkResponse: string = "";

    searchIngredientFormGroup = new UntypedFormGroup({
      strIngredient1: new UntypedFormControl(''),
    })
  
    searchIngredient() {
      // const postBar: PostBar = this.addIngredientFormGroup.value;
      // this._userBarService.postIngredient(postBar).subscribe();
    }

  ngOnInit(): void {
    const subscription = this._drinkService.getRandomDrink().subscribe(response => {
      this.drinkResponse = JSON.stringify(response, null, 2);
    });
  }
    
  toJson(obj: any){
    return JSON.stringify(obj, null, 2);
  }
}
