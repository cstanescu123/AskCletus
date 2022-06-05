import {
  Component,
  ElementRef,
  OnInit,
  ViewChild,
  AfterViewInit,
} from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { filter, fromEvent, map, mergeMap, Observable, switchMap } from 'rxjs';
import { PostBar } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css'],
})
export class AddIngredientComponent implements AfterViewInit {
  
  constructor(
    private _userBarService: UserBarServiceService,
    private _authService: AuthService,
    private _router: Router
  ) {}

  addIngredientControl = new FormControl();
  addingIngredient$ = this.addIngredientControl.valueChanges;

  userBar$ = this._authService.user$.pipe(
    filter((x) => x !== null),
    map((x) => x!.userId)
  );

  @ViewChild('button')
  getIngredientButton!: ElementRef<HTMLButtonElement>;

  click$!: Observable<any>;
  addIngredientClick$!: Observable<any>;

  submitIngredient() {
    //  let postBar: PostBar;
    //this._userBarService.postIngredient(postBar).subscribe();
  }

  //3 switchmaps to pipe to http request with form/id
  ngAfterViewInit(): void {
    this.click$ = fromEvent(this.getIngredientButton.nativeElement, 'click');
    //click button = event
    this.addIngredientClick$ = this.click$.pipe(
      //grab user info
      switchMap((_) => this.userBar$),
      //grab form info
      switchMap((_) => this.addingIngredient$),
      //send to post
      //switchMap(_ => this._userBarService.postIngredient())
     // switchMap(_ => this._router.navigate(["/app-bar-home"]))  
    );
  }
}
