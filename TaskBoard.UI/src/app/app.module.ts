import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CardComponent } from './card/card.component';
import { BoardHistoryComponent } from './board-history/board-history.component';
import { ListComponent } from './list/list.component';
import { CreateCardComponent } from './create-card/create-card.component';
import { ActivityComponent } from './activity/activity.component';
import { CardDetailsComponent } from './card-details/card-details.component';
import { AddListComponent } from './add-list/add-list.component';
import { EditListComponent } from './edit-list/edit-list.component';
import { FormsModule } from '@angular/forms';
import { EditCardComponent } from './edit-card/edit-card.component';

@NgModule({
  declarations: [
    AppComponent,
    CardComponent,
    BoardHistoryComponent,
    ListComponent,
    CreateCardComponent,
    ActivityComponent,
    CardDetailsComponent,
    AddListComponent,
    EditListComponent,
    EditCardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
