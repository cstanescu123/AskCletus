import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DrinkResponse } from './models/DrinkResponse';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DrinkServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Drink/";

  getRecentDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}recent`);
  }

}