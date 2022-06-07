import { Component, OnInit } from '@angular/core';
import { filter, map, mergeMap, switchMap } from 'rxjs';
import { User } from '../models/GithubUser';
import { AuthService } from '../Services/auth.service';
import { UserService } from '../Services/user.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {
  user$ = this._authService.user$;

  constructor(private _authService: AuthService,
              private _userService: UserService) { }

  user: User | null = null;

  userName$ = this._authService.user$.pipe(
    filter(x => x !== null),
    map(x => x!.userId),
    mergeMap(x => this._userService.getUser(x)),
  );

  ngOnInit(): void {
    const user = localStorage.getItem("user");
    if (user) {
      const currentUser = JSON.parse(user);

      this._authService.autoLogin(currentUser.userId).subscribe(user => {
        if (user) {
          this._authService.setUser(user);
        }
      });
    }
  }

  logout() {
    localStorage.setItem("user", "");
    this._authService.user$.pipe(
      filter(user => user !== null),
      switchMap(user => this._authService.logout(user!.userId))
    ).subscribe(_ => this._authService.setUser(null));
  }

}