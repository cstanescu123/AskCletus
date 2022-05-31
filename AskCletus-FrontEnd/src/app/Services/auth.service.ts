import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { User } from '../models/GithubUser';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private _http: HttpClient) { }

  baseUrl = "https://localhost:5001/auth";

  user$: ReplaySubject<User | null> = new ReplaySubject();

  setUser(user: User | null) {
    this.user$.next(user);
  }

  redirectGitHubToken() {
    const authState = uuidv4();
    localStorage.setItem("authState", authState);

    const queryParameters = [
      'client_id=ea9f15d9c88471a08302',
      `state=${authState}`,
      'allow_signup=true',
      encodeURIComponent('redirect_uri=http://localhost:4200/user-login'),
    ];

    window.location.href = `https://github.com/login/oauth/authorize?${queryParameters.join('&')}`;
  }

  githubLogin(code: string) {
    return this._http.get<User>(`${this.baseUrl}/login/${code}/Github`);
  }

  autoLogin(id: number) {
    return this._http.get<User>(`${this.baseUrl}/auto-login/${id}`);
  }

  logout(id: number) {
    return this._http.get(`${this.baseUrl}/logout/${id}`);
  }
}