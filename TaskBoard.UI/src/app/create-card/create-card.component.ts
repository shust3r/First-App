import { Component } from '@angular/core';
import { CardService } from '../Services/card.service';
import { ICard } from '../Interfaces/ICard';

@Component({
  selector: 'app-create-card',
  templateUrl: './create-card.component.html',
  styleUrl: './create-card.component.css'
})

export class CreateCardComponent {
  newCard : ICard = {
    name: "Testing HTTP POST method",
    description: "some Description",
    // dueDate: new Date('2024-05-25T03:24:00'),
    priority: 3
  }

  constructor(private cardSvc: CardService){}

  createCard() {
    this.cardSvc.createCard(this.newCard);
  }
}
