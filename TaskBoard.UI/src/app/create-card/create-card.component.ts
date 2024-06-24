import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { CardService } from '../Services/card.service';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-create-card',
  templateUrl: './create-card.component.html',
  styleUrl: './create-card.component.css'
})

export class CreateCardComponent implements OnChanges {
  @Input() currentListId: number;
  @Input() listNamesWithIds: IListNameId[];

  priorities = [{ id: 1, text:"Low" }, { id: 2, text:"Medium" }, { id: 3, text:"High"}];

  newCard : ICard = {
    name: "New card",
    description: "",
    priority: 1
  }

  constructor(private cardSvc: CardService){}
  ngOnChanges(changes: SimpleChanges): void {
    this.newCard.listId = this.currentListId;
  }

  createCard() {
    this.cardSvc.createCard(this.newCard).subscribe();
    window.location.reload();
  }

  closeModal() {
    window.location.reload();
  }
}
