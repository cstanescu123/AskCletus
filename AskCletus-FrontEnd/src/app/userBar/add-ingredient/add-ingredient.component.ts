import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
<<<<<<< HEAD
import { filter, fromEvent, map, mergeMap, Observable, switchMap } from 'rxjs';
=======
import { filter, map, mergeMap, switchMap } from 'rxjs';
>>>>>>> aa5aa601a50fff1fcef153b34f37a7b2342fb806
import { PostBar } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {
<<<<<<< HEAD
  constructor(
    private _userBarService: UserBarServiceService,
    private _authService: AuthService
  ) { }
=======
>>>>>>> aa5aa601a50fff1fcef153b34f37a7b2342fb806

  constructor(private _userBarService: UserBarServiceService,
              private _authService: AuthService) { }

    addIngredientFormGroup = new FormGroup({
    ingredient: new FormControl(''),
    userId: new FormControl(''),
  })

  addIngredient$ = this.addIngredientFormGroup.valueChanges;

  userBar$ = this._authService.user$.pipe(
    filter(x => x !== null),
    map(x => x!.userId),
    mergeMap(x => this._userBarService.getUserBar(x))
  );

  userId = this.userBar$
  
  submitIngredient() {
    const postBar: PostBar = this.addIngredientFormGroup.value;
    this._userBarService.postIngredient(postBar).subscribe();
  }

  ngOnInit(): void { }
}