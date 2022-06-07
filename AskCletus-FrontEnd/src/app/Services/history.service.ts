import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HistoryResponse } from 'src/app/models/HistoryResponse';

@Injectable({
  providedIn: 'root'
})
export class HistoryService {
  public get httpClient(): HttpClient {
    return this._httpClient;
  }

  constructor(private _httpClient: HttpClient) { }
  baseUrl = 
  //"https://askcletusbackend20220525201644.azurewebsites.net/DrinkHistory"
  //"https://askcletusbackendapi.azure-api.net/DrinkHistory";
  "https://localhost:5001/DrinkHistory";

  getHistories() { 
    return this.httpClient.get<Array<HistoryResponse>>(this.baseUrl);
  }

  public getHistory(userId: number) {
    return this.httpClient.get<Array<HistoryResponse>>(`${this.baseUrl}/${userId}`);
  }
}
