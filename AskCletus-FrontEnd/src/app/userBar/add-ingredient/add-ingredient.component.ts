import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { filter, map, switchMap } from 'rxjs';
import { PostBar } from 'src/app/models/IngredientsResponse';
import { UserBarServiceService } from 'src/app/Services/user-bar-service.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {

  constructor(private _userBarService: UserBarServiceService) { }

    addIngredientFormGroup = new FormGroup({
    ingredient: new FormControl(''),
    userId: new FormControl(''),
  })

  submitIngredient() {
    const postBar: PostBar = this.addIngredientFormGroup.value;
    this._userBarService.postIngredient(postBar).subscribe();
  }

  ngOnInit(): void { }
}