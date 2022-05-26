import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PostBar, UserBarResponse } from './models/IngredientsResponse';

@Injectable({
  providedIn: 'root'
})
export class UserBarServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Bar/";

  getUserBars() { 
    return this.httpClient.get<Array<UserBarResponse>>(this.baseUrl);
  }
  
  getUserBar(userId: number) { 
    return this.httpClient.get<UserBarResponse>(`${this.baseUrl}/${userId}`);
  }
    
  postIngredient(userBar: PostBar) {
    return this.httpClient.post<UserBarResponse>(this.baseUrl, userBar);
  }

  deleteIngredient(ingredientsId: number) {
    return this.httpClient.delete<UserBarResponse>(`${this.baseUrl}/${ingredientsId}`);
  }

}
