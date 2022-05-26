import { Component, OnInit } from '@angular/core';
import { switchMap } from 'rxjs';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-delete-user',
  templateUrl: './delete-user.component.html',
  styleUrls: ['./delete-user.component.css']
})
export class DeleteUserComponent implements OnInit {

  constructor(private _userService: UserService) { }



  ngOnInit(): void {
  }

}
