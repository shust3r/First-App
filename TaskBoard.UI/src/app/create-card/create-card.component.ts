import { Component, Input } from '@angular/core';
import { CardService } from '../Services/card.service';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-create-card',
  templateUrl: './create-card.component.html',
  styleUrl: './create-card.component.css'
})

export class CreateCardComponent {
  @Input() currentListId: number;
  @Input() isCreateCardOpened: boolean = true;
  @Input() listNamesWithIds: IListNameId[];

  newCard : ICard = {
    name: "Testing HTTP POST method",
    description: "some Description",
    priority: 3
  }

  constructor(private cardSvc: CardService){}

  createCard() {
    this.cardSvc.createCard(this.newCard);
  }
}
