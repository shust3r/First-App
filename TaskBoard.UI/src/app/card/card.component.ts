import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent implements OnInit {
  @Input() cards: ICard[];
  @Input() currentListId: number;
  @Input() listNamesWithIds: IListNameId[];
  listsToMove: IListNameId[] = [];
  card: ICard;
  isCardOpened: boolean = false;

  ngOnInit(): void {
    this.ListsToMove();
  }

  getPriority(priorityId: number) {
    if (priorityId == 1) return "Low";
    if (priorityId == 2) return "Medium";
    if (priorityId == 3) return "High";
  }

  cardClick(card: ICard) {
    this.card = card;
    this.isCardOpened = true;
  }

  ListsToMove() {
    this.listNamesWithIds.forEach(element => {
      if (element.id != this.currentListId)
        this.listsToMove.push(element);
    });
  }
}
