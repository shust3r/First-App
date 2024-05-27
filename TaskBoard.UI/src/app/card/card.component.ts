import { Component, Input, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { IListNameId } from '../Interfaces/IListNameId';
import { CardService } from '../Services/card.service';

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
  isCardOpened: boolean = false;
  cardId: number;
  card: ICard;
  
  constructor(private cardSvc: CardService) {}

  ngOnInit(): void {
    this.ListsToMove();
  }

  getPriority(priorityId: number) {
    if (priorityId == 1) return "Low";
    if (priorityId == 2) return "Medium";
    if (priorityId == 3) return "High";
  }

  ListsToMove() {
    this.listNamesWithIds.forEach(element => {
      if (element.id != this.currentListId)
        this.listsToMove.push(element);
    });
  }

  openCard(id: number) {
    this.cardSvc.getCardById(id).subscribe(r => {
      this.card = r;
    });
    
    this.isCardOpened = true;
  }

  humanizeDueDate(d: Date) : string{
    const date: Date = new Date(d);
    return date.toDateString();
  }

  // moveCard(c: number, id: number) {
  //   // c.listId = id;
  //   this.cardSvc.moveCard(c, id);
  // }
}
