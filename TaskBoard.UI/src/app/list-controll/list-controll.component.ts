import { Component, Input, OnInit } from '@angular/core';
import { IList } from '../Interfaces/IList';
import { ListService } from '../Services/list.service';

@Component({
  selector: 'app-list-controll',
  templateUrl: './list-controll.component.html',
  styleUrl: './list-controll.component.css'
})
export class ListControllComponent implements OnInit {
 @Input() list: IList;
 @Input() boardLists: IList[];
 listIdForCardCreation: number;
 isCreateCardOpened: boolean = false;

 constructor(private listSvc: ListService) { }

 ngOnInit(): void {
  this.list.isOnEdit = false;
 }

 deleteList(id: number) {
  this.listSvc.deleteListById(id);
  window.location.reload();
 }

 openCreateCard(listId: number) {
  this.listIdForCardCreation = listId;
  this.isCreateCardOpened = true;
}
}
