import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { filter, map, mergeMap, switchMap } from 'rxjs';
import { PostBar } from 'src/app/models/IngredientsResponse';
import { AuthService } from 'src/app/Services/auth.service';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {

  constructor(private _userBarService: UserBarServiceService,
              private _authService: AuthService) { }

    addIngredientFormGroup = new FormGroup({
    ingredient: new FormControl(''),
    userId: new FormControl(''),
  })

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