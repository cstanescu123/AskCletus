import {
  Component,
  ElementRef,
  OnInit,
  ViewChild,
  AfterViewInit,
  OnDestroy,
} from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Event, NavigationEnd, Router } from '@angular/router';
import {
  filter,
  fromEvent,
  map,
  mergeMap,
  Observable,
  of,
  Subscription,
  switchMap,
} from 'rxjs';
import { PostBar } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css'],
})
export class AddIngredientComponent implements AfterViewInit, OnDestroy {
  constructor(
    private _userBarService: UserBarServiceService,
    private _authService: AuthService,
    private _router: Router
    ) {
      this.userBarId$ = this._authService.user$.pipe(
        filter((x) => x !== null),
        map((x) => x!.userId)
        );
      }
    ngOnDestroy(): void {
      this.ingredientAndIdSubscription.unsubscribe();
  }

  ingredient = new FormControl();
  userId = new FormControl();
  ingredientAndIdSubscription!: Subscription;
  addIngredientControl = new FormControl();
  addingIngredient$ = this.addIngredientControl.valueChanges;
  click$!: Observable<MouseEvent>;
  addIngredientClick$!: Observable<any>;
  postBar$!: Observable<PostBar>;
  userBarId$: Observable<any>;

  @ViewChild('button')
  getIngredientButton!: ElementRef<HTMLButtonElement>;  
  //3 switchmaps to pipe to http request with form/id
  //click button = event
  //grab form info
  //send to post
  ngAfterViewInit(): void {
    this.click$ = fromEvent<MouseEvent>(
      this.getIngredientButton.nativeElement,
      'click');
      /* the parameter of an OPERATOR is the data passed in from the last operator or pipe*/
      // literally true for EVERY rxjs operator
      this.postBar$ = this.click$.pipe(
      mergeMap((_clickEvent) => this.addingIngredient$),
      mergeMap((ingredient) =>
        this.userBarId$.pipe(map((userId) => ({ userId, ingredient })))),
      mergeMap((ingredientAndId: { ingredient: string; userId: number }) =>
        this._userBarService.postIngredientAndUserId(ingredientAndId)));
    this.ingredientAndIdSubscription = this.postBar$.subscribe(() => this._router.navigate(["bar-home"]))
  }
}