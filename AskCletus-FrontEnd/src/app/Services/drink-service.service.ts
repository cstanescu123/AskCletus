import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DrinkResponse } from 'src/app/models/DrinkResponse';

@Injectable({
  providedIn: 'root'
})
export class DrinkServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Drink/";

  public getRecentDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}recent`);
  }

  public getRandomDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}random`)
  }



  // getDrink(id: number) {
  //   return this.httpClient.get<Drink>(`${this.baseUrl}people/${id}`);
  // }
}