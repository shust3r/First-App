import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { IList } from '../Interfaces/IList';
import { ListService } from '../Services/list.service';
import { Board } from '../Interfaces/board';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnChanges {
  @Input() board: Board;
  lists: IList[] = [];
  isCreateCardOpened: boolean = false;
  listIdForCardCreation: number;
  emptyPillars: number[] = [];

  constructor(
    private listSvc: ListService
  ) {  }

  ngOnChanges(changes: SimpleChanges): void {
    this.listSvc.getLists(this.board.id).subscribe(response => {
      this.lists = response;
    });
  }

  openCreateCard(listId: number) {
    this.listIdForCardCreation = listId;
    this.isCreateCardOpened = true;
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
