import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';
import { UserBarResponse } from 'src/app/models/UserBarResponse';
import { UserBarServiceService } from 'src/app/user-bar-service.service';

@Component({
  selector: 'app-bar-home',
  templateUrl: './bar-home.component.html',
  styleUrls: ['./bar-home.component.css']
})
export class BarHomeComponent implements OnInit {
  
  constructor(
    private _activatedRoute: ActivatedRoute, 
    private _userBarService: UserBarServiceService
  ) { }

  userBar$ = this._activatedRoute.paramMap.pipe(
  map(params => params.get('ingredientsId')), 
  filter(ingredientsId => ingredientsId !== null), 
  map(ingredientsId => parseInt(ingredientsId as string, 10)),
  switchMap((ingredientsId: number) => this._userBarService.getUserBar(ingredientsId)),
  )
  
  ngOnInit(): void {
  }
}
