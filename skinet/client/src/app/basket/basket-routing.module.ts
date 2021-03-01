import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketComponent } from './basket.component';
import { Routes } from '@angular/router';

const routes: Routes = [
  {path: '', component: BasketComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class BasketRoutingModule { }
