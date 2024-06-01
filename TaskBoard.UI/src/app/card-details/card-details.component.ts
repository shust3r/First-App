import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { CardService } from '../Services/card.service';

@Component({
  selector: 'app-card-details',
  templateUrl: './card-details.component.html',
  styleUrl: './card-details.component.css'
})
export class CardDetailsComponent implements OnInit {
  isCardOpened: boolean = true;
  @Input() card: ICard;

  constructor(private cardSvc: CardService) {}

  ngOnInit(): void {
  }

  closeCard() {
    this.isCardOpened = false;
    window.location.reload();
  }
}
