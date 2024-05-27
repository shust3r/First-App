import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { CardService } from '../Services/card.service';

@Component({
  selector: 'app-card-details',
  templateUrl: './card-details.component.html',
  styleUrl: './card-details.component.css'
})
export class CardDetailsComponent implements OnInit {
  @Input() isCardOpened: boolean = false;
  @Input() cardId: number;
  card: ICard;

  constructor(private cardSvc: CardService) {}

  ngOnInit(): void {
    this.cardSvc.getCardById(this.cardId).subscribe(r => {
      this.card = r;
    });
  }
}
