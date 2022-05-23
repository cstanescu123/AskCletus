import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HistoryService {
  public get httpClient(): HttpClient {
    return this._httpClient;
  }
  

  constructor(private _httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Drink/";

  public getRecentDrink(): Observable<DrinkResponse> {
    return this.httpClient.get<DrinkResponse>(`${this.baseUrl}recent`);
  
  }
}
