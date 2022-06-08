import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { MatCardModule } from '@angular/material/card';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatButtonModule} from '@angular/material/button';
import {MatIcon, MatIconModule} from '@angular/material/icon';
import {MatListModule} from '@angular/material/list';

import { BarHomeComponent } from './userBar/bar-home/bar-home.component';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';
import { DrinkHistoryComponent } from './drinkHistory/drink-history/drink-history.component';
import { DeleteUserComponent } from './user/delete-user/delete-user.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { NavigationComponent } from './navigation/navigation.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { SearchResultsComponent } from './search-results/search-results.component';
import { GetRandomComponent } from './get-random/get-random.component';
import { GetDrinkNameComponent } from './get-drink-name/get-drink-name.component';
import { GetDrinkIngredientComponent } from './get-drink-ingredient/get-drink-ingredient.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatMenuModule} from '@angular/material/menu';
import {DragDropModule} from '@angular/cdk/drag-drop';
import { GuestComponent } from './guest/guest.component';
import { RouterModule } from '@angular/router';

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
    GetRandomComponent,
    GetDrinkNameComponent,
    GetDrinkIngredientComponent,
    GuestComponent,

  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatCardModule,
    MatButtonModule,
    BrowserAnimationsModule,
    MatIconModule,
    MatMenuModule,
    DragDropModule,
    MatListModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
