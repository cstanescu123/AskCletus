import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { filter, fromEvent, map, mergeMap, Observable, switchMap } from 'rxjs';
import { PostBar } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css'],
})
export class AddIngredientComponent implements OnInit {
  constructor(
    private _userBarService: UserBarServiceService,
    private _authService: AuthService
  ) { }

  addIngredientFormGroup = new FormGroup({
    ingredient: new FormControl(''),
  });

  addIngredient$ = this.addIngredientFormGroup.valueChanges;

  userBar$ = this._authService.user$.pipe(
    filter((x) => x !== null),
    map((x) => x!.userId)
  );
    
    //3 switchmaps to pipe to http request with form/id
    //click button = event
    //grab user info
    //grab form info
    //send to post
@ViewChild('button')
getIngredientButton!: ElementRef<HTMLButtonElement>

click$!: Observable<any>;
addIngredientClick$!: Observable<any>;

ngAfterViewInit(): void {
  this.click$ = fromEvent(this.getIngredientButton.nativeElement, 'click');
  this.addIngredientClick$ = this.click$.pipe(
    mergeMap(_ => this.userBar$),
    mergeMap(_ => this.addIngredient$),
    //mergeMap(_ => )
  );
}

  submitIngredient() {
    const postBar: PostBar = this.addIngredientFormGroup.value;
    this._userBarService.postIngredient(postBar).subscribe();
  }

  ngOnInit(): void {}
}
