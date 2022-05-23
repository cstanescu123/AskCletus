import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { HistoryResponse } from './models/HistoryResponse';

@Injectable({
  providedIn: 'root'
})
export class HistoryService {
  public get httpClient(): HttpClient {
    return this._httpClient;
  }
  

  constructor(private _httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Drink/";

  public getHistory(historyId: number): Observable<HistoryResponse> {
    return this.httpClient.get<HistoryResponse>(`${this.baseUrl}recent`);
  
  }
}
