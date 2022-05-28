import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';

import { NavigationComponent } from './navigation/navigation.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { DeleteUserComponent } from './user/delete-user/delete-user.component';
import { BarHomeComponent } from './userBar/bar-home/bar-home.component';

const routes: Routes = [

  {
    path: 'addIngredient', 
    component: AddIngredientComponent
  },
  {
    path: "user-login",
    component: UserLoginComponent
  },
  {
    path: "app-delete-user",
    component: DeleteUserComponent
  },
  {
    path: "app-bar-home",
    component: BarHomeComponent
  }
 
  //define routes here

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
