import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { User } from '../models/GithubUser';
import { env } from './environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private _http: HttpClient) { }

  baseUrl = 
  "https://askcletusbackend20220525201644.azurewebsites.net/Auth"
  // "https://localhost:5001/Auth";

  user$: ReplaySubject<User | null> = new ReplaySubject();

  setUser(user: User | null) {
    this.user$.next(user);
  }

  redirectGitHubToken() {
    const authState = uuidv4();
    localStorage.setItem("authState", authState);

    const clientId = "ea9f15d9c88471a08302";
    

    const queryParameters = [
      `client_id=ea9f15d9c88471a08302`,
      `state=${authState}`,
      'allow_signup=true',
      encodeURIComponent('redirect_uri=https://salmon-beach-09e8d8e10.1.azurestaticapps.net/'),
      // encodeURIComponent(redirectUri),
    ];

    window.location.href = `https://github.com/login/oauth/authorize?${queryParameters.join('&')}`;
  }

  //https://localhost:5001/Auth/                  login/ 23/   Github
  githubLogin(code: string) {
    return this._http.get<User>(`${this.baseUrl}/login/${code}/Github`);
  }

  autoLogin(userId: number) {
    return this._http.get<User>(`${this.baseUrl}/auto-login/${userId}`);
  }

  logout(userId: number) {
    return this._http.get(`${this.baseUrl}/logout/${userId}`);
  }
}