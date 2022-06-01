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
import { UserLoginComponent } from './user/user-login/user-login.component';
import { NavigationComponent } from './navigation/navigation.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { SearchResultsComponent } from './search-results/search-results.component';
import { SearchFunctionsComponent } from './search-functions/search-functions.component';
import { SignInComponent } from './sign-in/sign-in.component';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';



@NgModule({
  declarations: [
    AppComponent,
    BarHomeComponent,
    AddIngredientComponent,
    DeleteUserComponent,
    UserLoginComponent,
    DrinkHistoryComponent,
    NavigationComponent,
    WelcomePageComponent,
    SearchResultsComponent,
    SearchFunctionsComponent,
    SignInComponent,
    
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatCardModule,
    MatButtonModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
