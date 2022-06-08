import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Services/auth.service';
import { map } from 'rxjs/internal/operators/map';
import { filter } from 'rxjs/internal/operators/filter';
import { switchMap } from 'rxjs/internal/operators/switchMap';
import { tap } from 'rxjs';
@Component({
  selector: 'app-welcome-page',
  templateUrl: './welcome-page.component.html',
  styleUrls: ['./welcome-page.component.css']
})
export class WelcomePageComponent implements OnInit {

  constructor(
    private _activatedRoute: ActivatedRoute,
    private _authService: AuthService,
    private _router: Router) { }

  onGithubLogin() {
    this._authService.redirectGitHubToken();
  }


  ngOnInit(): void {
    // localhost:4200/?code=12345&state=123435
    this._activatedRoute.queryParams.pipe(
      map(params => ({code: params["code"], state: params["state"]})),
      // tap(obj => alert(`before filter: ${JSON.stringify(obj)}`)),
      filter(p => p.code && p.state && p.state === localStorage.getItem("authState")),
      // tap(obj => alert(`after filter: ${JSON.stringify(obj)}`)),
      switchMap(({code}: {code: string}) => this._authService.githubLogin(code)),
      // tap(obj => alert(`after  login api call: ${JSON.stringify(obj)}`)),
    ) 
    .subscribe(user => {
      localStorage.setItem("user", JSON.stringify(user));
      this._authService.setUser(user);
      this._router.navigate(["/","app-bar-home"]);
    });
  }

}