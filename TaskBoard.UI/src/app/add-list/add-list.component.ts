import { Component, Input } from '@angular/core';
import { ListService } from '../Services/list.service';

@Component({
  selector: 'app-add-list',
  templateUrl: './add-list.component.html',
  styleUrl: './add-list.component.css'
})
export class AddListComponent {
  @Input() boardId: number;
  isFormOpened: boolean = false;

  constructor(private listSvc: ListService) {}

  openCreateListForm() {
    this.isFormOpened = true;
  }

  addList() {
    const name = (document.getElementById('listName') as HTMLInputElement).value;
    
    if(name != "" && name != " ")
      {
        this.listSvc.createList(name, this.boardId).subscribe(r =>
          console.log(r)
        );
        window.location.reload();
      }
  }

  cancel() {
    this.isFormOpened = false;
  }
}
