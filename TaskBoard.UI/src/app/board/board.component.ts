import { Component, OnInit, Output, output } from '@angular/core';
import { BoardService } from '../Services/board.service';
import { Board } from '../Interfaces/board';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrl: './board.component.css'
})
export class BoardComponent implements OnInit {
  isForRenaming: boolean = false;
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
    this.boardSvc.openedBoard = this.boards[0];
  }

  renameBoard() {
    const name = (document.getElementById('name') as HTMLInputElement).value;
    if(name === this.board.name) {
      this.cancel();
    }
    else if(name != "" && name != " ") {
      this.board.name = name;
      this.boardSvc.rename(name, this.board.id);
    }    
  }

  cancel() {
    this.isForRenaming = false;
  }

  //TODO: 
  switchBoard(board: Board) {
    console.log(`Switching to the ${board.name} board with id ${board.id}`);
    this.boardSvc.openedBoard = board;
    this.board = board;
  }

  //TODO: Check the board and ask twice if the board lists length is not 0
  deleteBoard() {
    if(this.isDeleteAllowed()) this.boardSvc.delete(this.board.id);
    else console.log(`Cannot delete the ${this.board.name} with id ${this.board.id}`);
  }

  isDeleteAllowed(): boolean {
    return this.boards.length > 1 &&  this.board.id != 1;
  }
}
