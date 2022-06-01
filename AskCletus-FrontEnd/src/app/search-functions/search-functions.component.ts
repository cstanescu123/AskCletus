import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DrinkServiceService } from '../Services/drink-service.service';
import { UserBarServiceService } from '../Services/user-bar-service.service';

@Component({
  selector: 'app-search-functions',
  templateUrl: './search-functions.component.html',
  styleUrls: ['./search-functions.component.css']
})
export class SearchFunctionsComponent implements OnInit {

  constructor
  ( private _drinkService: DrinkServiceService, 
    private _activatedRoute: ActivatedRoute,
    private _userBarService: UserBarServiceService) { 
      //this.drink$ = this._drinkService.getRecentDrink();
    }
    drinkResponse: string = "";


    searchIngredientFormGroup = new FormGroup({
      strIngredient1: new FormControl(''),
    })
  
    // searchIngredient() {
    //   const postBar: PostBar = this.addIngredientFormGroup.value;
    //   this._userBarService.postIngredient(postBar).subscribe();
    // }


  ngOnInit(): void {
    const subscription = this._drinkService.getRandomDrink().subscribe(response => {
      this.drinkResponse = JSON.stringify(response, null, 2);
    });
  }
    
  toJson(obj: any){
    return JSON.stringify(obj, null, 2);
  }

}
