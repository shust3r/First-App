import { Component, OnInit} from '@angular/core';
import { BoardService } from './Services/board.service';
import { Board } from './Interfaces/board';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  isForRenaming: boolean = false;
  isForCreating: boolean = false;
  board: Board = {
    id: -1,
    name: "",
    lists: null };
  
  boards: Board[] = [ this.board ];

  constructor(private boardSvc: BoardService) {  }

  ngOnInit(): void {
    this.boardSvc.getAll().subscribe(r => {
      this.boards = r;
    });

    this.board = this.boards[0];
  }

  renameBoard() {
    const name = (document.getElementById('name') as HTMLInputElement).value;
    if(name === this.board.name) {
      this.cancel();
    }
    else if(name != "" && name != " ") {
      this.boardSvc.rename(name, this.board.id);
      this.board.name = name;
      this.cancel();
    }    
  }

  createBoard() {
    const name = (document.getElementById('newName') as HTMLInputElement).value;
    if(name != "" && name != " ") {
      this.boardSvc.create(name).subscribe(r => {
        this.board = r;
        this.boards.push(r);
      });
    }
    this.isForCreating = false;
  }

  cancel() {
    this.isForRenaming = false;
  }

  switchBoard(board: Board) {
    this.board = board;
  }

  deleteBoard() {
    if(this.isDeleteAllowed()) {
      this.boardSvc.delete(this.board.id);
      this.boards = this.boards.filter(b => { return b !== this.board} );
      this.board = this.boards[0];
    }
    else console.log(`Cannot delete the ${this.board.name} with id ${this.board.id}`);
  }

  isDeleteAllowed(): boolean {
    return this.boards.length > 1 && this.board.id != 1;
  }
}
