import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';
import { CardService } from '../Services/card.service';
import { ActivityService } from '../Services/activity.service';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent implements OnInit {
  @Input() listId: number;
  @Input() lists: IListNameId[];
  cards: ICard[];
  listsToMove: IListNameId[] = [];
  isCardOpened: boolean = false;
  cardId: number;
  isEditCard: boolean = false;
  card: ICard;

  constructor(private cardSvc: CardService, private actSvc: ActivityService) {}

  ngOnInit(): void {
    this.cardSvc.getCards(this.listId).subscribe(r => {
      this.cards = r;
    });

    this.MakeListsToMove();
  }

  getPriority(priorityId: number) {
    if (priorityId == 1) return "Low";
    if (priorityId == 2) return "Medium";
    if (priorityId == 3) return "High";
  }

  MakeListsToMove() {
    this.lists.forEach(l => {
      if (l.id != this.listId)
        this.listsToMove.push(l);
    });
  }

  openCard(card: ICard) {
    this.actSvc.getCardActivities(card.id).subscribe(r => {
      card.activities = r;
    });

    this.cardId = card.id;
    this.card = card;
    this.isCardOpened = true;
  }

  editCard(card: ICard) {
    this.card = card;
    this.isEditCard = true;
  }

  humanizeDueDate(d: Date) : string{
    const date: Date = new Date(d);
    return date.toDateString();
  }

  moveCard(cardId: number, listId: number) {
    this.cardSvc.moveCard(cardId, listId);
  }

  deleteCard(cardId: number) {
    this.cardSvc.deleteCard(cardId);
    
    window.location.reload();
  }
}
