import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Services/auth.service';
import { map } from 'rxjs/internal/operators/map';
import { filter } from 'rxjs/internal/operators/filter';
import { switchMap } from 'rxjs/internal/operators/switchMap';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  constructor(
    private _activatedRoute: ActivatedRoute,
    private _authService: AuthService,
    private _router: Router) { }

  onGithubLogin() {
    this._authService.redirectGitHubToken();
  }


  ngOnInit(): void {
    
    this._activatedRoute.queryParams.pipe(
      map(params => ({code: params["code"], state: params["state"]})),
      filter(p => p.code && p.state && p.state === localStorage.getItem("authState")),
      switchMap((p: {code: string}) => this._authService.githubLogin(p.code))
    ) 
    .subscribe(user => {
      localStorage.setItem("user", JSON.stringify(user));
      this._authService.setUser(user);
      this._router.navigate(["/app-bar-home"]);
    });
  }

}