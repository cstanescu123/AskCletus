import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PostBar, UserBarResponse } from './models/UserBarResponse';

@Injectable({
  providedIn: 'root'
})
export class UserBarServiceService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = "https://localhost:5001/Bar/";

  getUserBars() { 
    return this.httpClient.get<Array<UserBarResponse>>(this.baseUrl);
  }
  
  getUserBar(ingredientsId: number) { 
    return this.httpClient.get<UserBarResponse>(`${this.baseUrl}/${ingredientsId}`);
  }
    
  postIngredient(userBar: PostBar) {
    return this.httpClient.post<UserBarResponse>(this.baseUrl, userBar);
  }

  deleteStudent(ingredientsId: number) {
    return this.httpClient.delete<UserBarResponse>(`${this.baseUrl}/${ingredientsId}`);
  }

}
