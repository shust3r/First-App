import { Component, Input } from '@angular/core';
import { ListService } from '../Services/list.service';

@Component({
  selector: 'app-edit-list',
  templateUrl: './edit-list.component.html',
  styleUrl: './edit-list.component.css'
})
export class EditListComponent {
  @Input() listName: string;
  @Input() listId: number;

  constructor(private listSvc: ListService) {}
  
  changeList() {
    const name = (document.getElementById('name') as HTMLInputElement).value;
    if(name === this.listName)
      window.location.reload();

    if(name != "" && name != " ")
      this.listSvc.renameList(name, this.listId)
    
    window.location.reload();
  }

  cancel() {
    window.location.reload();
  }
}
