import { Component, OnInit } from '@angular/core';
import { filter, map, mergeMap } from 'rxjs';
import { AuthService } from './Services/auth.service';
import { UserService } from './Services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'AskCletus-FrontEnd';

constructor(private _authService: AuthService,
            private _userService: UserService) {}

userBar$ = this._authService.user$.pipe(
  filter(x => x !== null),
  map(x => x!.userId),
  mergeMap(x => this._userService.getUser(x)),
);

  ngOnInit(){
  }
}
