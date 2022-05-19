import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Drink, DrinkResponse } from './models/DrinkResponse';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DrinkServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Drink/";

  public getRecentDrink(): Observable<Drink> {
    return this.httpClient.get<Drink>(`${this.baseUrl}recent`);
  
  }
  getDrink(id: number) {
    return this.httpClient.get<Drink>(`${this.baseUrl}people/${id}`);
  }
}