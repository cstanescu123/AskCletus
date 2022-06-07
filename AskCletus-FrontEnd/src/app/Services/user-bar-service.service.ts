import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IngredientsResponse, PostBar, PostIngredientDrinkId } from 'src/app/models/IngredientsResponse';

@Injectable({
  providedIn: 'root'
})
export class UserBarServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://askcletusbackendapi.azure-api.net/Bar"; 
  //"https://localhost:5001/Bar";

  getUserBars() { 
    return this.httpClient.get<Array<IngredientsResponse>>(this.baseUrl);
  }
  
  getUserBar(userId: number) { 
    return this.httpClient.get<Array<IngredientsResponse>>(`${this.baseUrl}/${userId}`);
  }
    
  postIngredient(userBar: PostBar) {
    return this.httpClient.post<IngredientsResponse>(this.baseUrl, userBar);
  }

  postIngredientAndUserId(userAndId: PostIngredientDrinkId) {
    return this.httpClient.post<IngredientsResponse>(this.baseUrl, userAndId);
  }

  deleteIngredient(ingredientId: number) {
    return this.httpClient.delete<IngredientsResponse>(`${this.baseUrl}/${ingredientId}`);
  }
}
