import { Component, OnInit } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { IList } from '../Interfaces/IList';
import { CardService } from '../Services/card.service';
import { ListService } from '../Services/list.service';
import { IListNameId } from '../Interfaces/IListNameId';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnInit {
  lists: IList[] = [];
  cards: ICard[] = [];
  isCreateCardOpened: boolean = false;
  listIdForCardCreation: number;
  listNamesWithIds: IListNameId[] = [];

  constructor(
    private cardSvc: CardService,
    private listSvc: ListService
  ) {  }
  
  ngOnInit(): void {
    this.cardSvc.getCards().subscribe(response => {
      this.cards = response;
    });

    this.listSvc.getLists().subscribe(response => {
      this.lists = response;
    });
    
    this.listSvc.getListNamesWithIds().subscribe( r => {
      this.listNamesWithIds = r;
    })
  }

  openCreate(listId: number) {
    this.listIdForCardCreation = listId;
    this.isCreateCardOpened = true;
  }

  // deleteList(list: IList) {
  //   this.listSvc.deleteListById(list.id);
  // }
}
