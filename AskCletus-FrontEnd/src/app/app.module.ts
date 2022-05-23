import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BarHomeComponent } from './userBar/bar-home/bar-home.component';
import { AddIngredientComponent } from './userBar/add-ingredient/add-ingredient.component';
import { UpdateUserComponent } from './user/update-user/update-user.component';
import { DeleteUserComponent } from './user/delete-user/delete-user.component';
import { UserLoginComponent } from './user/user-login/user-login.component';


@NgModule({
  declarations: [
    AppComponent,
    BarHomeComponent,
    AddIngredientComponent,
    UpdateUserComponent,
    DeleteUserComponent,
    UserLoginComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
