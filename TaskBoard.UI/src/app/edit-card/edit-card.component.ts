import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { CardService } from '../Services/card.service';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-edit-card',
  templateUrl: './edit-card.component.html',
  styleUrl: './edit-card.component.css'
})
export class EditCardComponent implements OnInit {
  @Input() oldCard: ICard;
  @Input() listNamesWithIds: IListNameId[];
  changedCard : ICard = {
    name: "New card",
    description: "",
    priority: 1
  }

  priorities = [{ id: 1, text:"Low" }, { id: 2, text:"Medium" }, { id: 3, text:"High"}];

  constructor(private cardSvc: CardService) {  }

  ngOnInit(): void {
    this.seedCard();
  }

  changeCard() {
    this.cardSvc.changeCard(this.changedCard, this.oldCard);
    
    window.location.reload();
  }
  
  closeModal() {
    window.location.reload();
  }

  seedCard() {
    this.changedCard = {
      id: this.oldCard.id,
      name: this.oldCard.name,
      listId: this.oldCard.listId,
      description: this.oldCard.description,
      priority: this.oldCard.priority,
    }
  }
}
