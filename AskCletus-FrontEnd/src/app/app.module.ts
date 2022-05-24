import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BarHomeComponent } from './userBar/bar-home/bar-home.component';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';
import { DrinkHistoryComponent } from './drinkHistory/drink-history/drink-history.component';
import { DeleteUserComponent } from './user/delete-user/delete-user.component';
<<<<<<< HEAD
import { GetUserComponent } from './user/get-user/get-user.component';
import { GetUsersComponent } from './user/get-users/get-users.component';
import { NavigationComponent } from './navigation/navigation.component';


=======
import { UserLoginComponent } from './user/user-login/user-login.component';
>>>>>>> f75c06826343949f4f0eeabedc2be3a78761779a


@NgModule({
  declarations: [
    AppComponent,
    BarHomeComponent,
    AddIngredientComponent,
    DeleteUserComponent,
<<<<<<< HEAD
    NavigationComponent,
=======
    UserLoginComponent,
    DrinkHistoryComponent
>>>>>>> f75c06826343949f4f0eeabedc2be3a78761779a
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
