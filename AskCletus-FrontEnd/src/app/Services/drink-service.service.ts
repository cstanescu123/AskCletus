import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DrinkResponse } from 'src/app/models/DrinkResponse';

@Injectable({
  providedIn: 'root'
})
export class DrinkServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = 
  //"https://askcletusbackend20220525201644.azurewebsites.net/Drink"
  //"https://askcletusbackendapi.azure-api.net/Drink";
  "https://localhost:5001/Drink";

  public getRecentDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/recent`);
  }
  public getRandomDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/random`)
  }
  public getDrink(name: string): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/IngredientSearch?ingredientName=${name}`);
  }
  public getDrinkById(drinkId: number): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/${drinkId}`)
  }
  public getDrinkByName(name: string): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/DrinkName?drinkName=${name}`);
  }
  public getDrinkByIngredient(ingredient: string): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}/IngredientSearch?ingredientName=${ingredient}`);
  }
}
