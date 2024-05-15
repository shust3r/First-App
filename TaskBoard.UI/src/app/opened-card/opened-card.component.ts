import { Component, Input } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { CardService } from '../Services/card.service';

@Component({
  selector: 'app-opened-card',
  templateUrl: './opened-card.component.html',
  styleUrl: './opened-card.component.css'
})
export class OpenedCardComponent {
@Input() card: ICard;
@Input() isCardOpened: boolean;

constructor(
  private cardSvc: CardService
) {}

closeBtn() {
  this.isCardOpened = false;
}
}
