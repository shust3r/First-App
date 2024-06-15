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
  emptyPillars: number[] = [];

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

  openCreateCard(listId: number) {
    this.listIdForCardCreation = listId;
    this.isCreateCardOpened = true;
  }

  getFreeSpaceAmount() {
    const amount = 4 - this.listNamesWithIds.length;
  }

  getEmptyLists(): number[] {
    const len = 4 - this.lists.length;
    return new Array<number>(len);
  }

  deleteList(id: number) {
    this.listSvc.deleteListById(id);
    window.location.reload();
  }
}
