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

constructor() {}

  ngOnInit(){
  }
}
