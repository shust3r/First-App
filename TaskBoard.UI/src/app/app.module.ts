import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CardComponent } from './card/card.component';
import { BoardHistoryComponent } from './board-history/board-history.component';
import { ListComponent } from './list/list.component';
import { OpenedCardComponent } from './opened-card/opened-card.component';
import { CreateCardComponent } from './create-card/create-card.component';
import { ActivityComponent } from './activity/activity.component';
import { CardDetailsComponent } from './card-details/card-details.component';
import { AddListComponent } from './add-list/add-list.component';

@NgModule({
  declarations: [
    AppComponent,
    CardComponent,
    BoardHistoryComponent,
    ListComponent,
    OpenedCardComponent,
    CreateCardComponent,
    ActivityComponent,
    CardDetailsComponent,
    AddListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
