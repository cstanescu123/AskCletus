import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { UserResponse } from 'src/app/models/UserResponse';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  constructor(router: Router, _userService: UserService) { }

  userLoginFormGroup = new FormGroup({
    userName: new FormControl(''),
    password: new FormControl(''),
  })

  user: UserResponse[] = []

  ngOnInit(): void {
  }

}
