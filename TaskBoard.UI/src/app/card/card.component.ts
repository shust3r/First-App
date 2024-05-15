import { Component, Input, Output, EventEmitter } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { IList } from '../Interfaces/IList';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent {
  @Input() cards: ICard[];
  @Input() lists: IList[];
  card: ICard;
  isCardOpened: boolean = false;

  getPriority(priorityId: number) {
    if (priorityId == 1) return "Low";
    if (priorityId == 2) return "Medium";
    if (priorityId == 3) return "High";
  }

  cardClick(card: ICard) {
    this.card = card;
    this.isCardOpened = true;
  }
}
