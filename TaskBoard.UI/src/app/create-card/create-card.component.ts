import { Component, Input, OnInit } from '@angular/core';
import { CardService } from '../Services/card.service';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-create-card',
  templateUrl: './create-card.component.html',
  styleUrl: './create-card.component.css'
})

export class CreateCardComponent implements OnInit {
  @Input() currentListId: number;
  @Input() listNamesWithIds: IListNameId[];
  @Input() oldCard: ICard | null;
  
  priorities = [{ id: 1, text:"Low" }, { id: 2, text:"Medium" }, { id: 3, text:"High"}];

  newCard : ICard = {
    name: "New card",
    description: "",
    priority: 1
  }

  constructor(private cardSvc: CardService){}
  ngOnInit(): void {
    if(this.oldCard != null)
      this.newCard = this.oldCard;
    else
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
