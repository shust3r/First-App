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

  priorities = [{ id: 1, text:"Low" }, { id: 2, text:"Medium" }, { id: 3, text:"High"}];

  newCard : ICard = {
    name: "New card",
    description: "",
    priority: 1,
    listId: -1
  }

  constructor(private cardSvc: CardService){}
  ngOnInit(): void {
    // console.log(this.currentListId); //undefined
      //this.newCard.listId = this.currentListId;

      // this.fixLists();
  }

  // fixLists() {
  //   let index: number = -1;
  //   for (let el of this.listNamesWithIds){
  //       if(el.id === this.newCard.listId){
  //       console.log(el.id);
  //       console.log(this.currentListId);
  //       this.currentList = el;
  //       index = this.listNamesWithIds.indexOf(el);
  //       break;
  //     }
  //   }
  //   delete this.listNamesWithIds[index];
  // }

  createCard() {
    this.cardSvc.createCard(this.newCard).subscribe();
    window.location.reload();
  }

  closeModal() {
    window.location.reload();
  }
}
