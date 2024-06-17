import { Component, OnInit } from '@angular/core';
import { BoardService } from '../Services/board.service';
import { Board } from '../Interfaces/board';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrl: './board.component.css'
})
export class BoardComponent implements OnInit {
  board: Board;

  constructor(private boardSvc: BoardService) {  }

  ngOnInit(): void {
    this.boardSvc.getById(1).subscribe(response => {
      this.board = response;
    });
  }
}
