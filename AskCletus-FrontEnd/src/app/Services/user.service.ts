import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserResponse } from 'src/app/models/UserResponse';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient: HttpClient) { }
  baseUrl = 
  "https://askcletusbackend20220525201644.azurewebsites.net/user"
  //"https://askcletusbackendapi.azure-api.net/user";
  //"https://localhost:5001/user";
  
  deleteUser(userId: number) {
    return this.httpClient.delete<UserResponse>(`${this.baseUrl}/${userId}`);
  }

  getUser(userId: number) {
    return this.httpClient.get<UserResponse>(`${this.baseUrl}/${userId}`);
  }
}
