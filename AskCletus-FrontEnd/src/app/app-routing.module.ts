import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';

import { UserHomeComponent } from './user/user-home/user-home.component';
import { NavigationComponent } from './navigation/navigation.component';

const routes: Routes = [

  {path: 'addIngredient', component: AddIngredientComponent},
  {path: 'addUser', component: UserHomeComponent}
 
  //define routes here

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
