import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';

import { UserLoginComponent } from './user/user-login/user-login.component';
import { DeleteUserComponent } from './user/delete-user/delete-user.component';
import { BarHomeComponent } from './userBar/bar-home/bar-home.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { DrinkHistoryComponent } from './drinkHistory/drink-history/drink-history.component';
import { SearchResultsComponent } from './search-results/search-results.component';
import { GuestComponent } from './guest/guest.component';

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
  },
  {
    path: "app-drink-history",
    component: DrinkHistoryComponent
  },
  {
    path: "search-results/:id",
    component: SearchResultsComponent
  },
  {
    path: "guest",
    component: GuestComponent
  },
  {
    path: '',
    component: WelcomePageComponent
  }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
