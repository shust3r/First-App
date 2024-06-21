import { Component, OnInit } from '@angular/core';
import { IActivity } from '../Interfaces/IActivity';
import { ActivityService } from '../Services/activity.service';
import { BoardService } from '../Services/board.service';


@Component({
  selector: 'app-board-history',
  templateUrl: './board-history.component.html',
  styleUrl: './board-history.component.css'
})
export class BoardHistoryComponent implements OnInit {
  boardId : number;
  boardActivities: IActivity[] = [];
  activitiesToShow: IActivity[] = [];
  currentPage: number = 0;
  activitiesAmount: number = 6;
  endIndex: number = this.activitiesAmount;
  isOpened: boolean = false;

  constructor(
    private boardSvc: BoardService,
    private actSvc: ActivityService
  ) {}

  ngOnInit(): void {
    this.loadActivities(this.boardSvc.openedBoard.id);
  }

  switchHistory() {
    if(!this.isOpened) {
      this.boardId = this.boardSvc.openedBoard.id;
      this.showMore();
      this.loadActivities(this.boardId);
      this.isOpened = true;
    }
    else this.isOpened = false;
  }

  loadActivities(id: number): void {
    this.actSvc.getActivities(id).subscribe(response => {
      this.boardActivities = response;
    });
  }

  showMore() {
    if (this.activitiesToShow.length < this.activitiesAmount) {
      this.currentPage = 0;
      this.endIndex = this.activitiesAmount;
    }
    else {
      this.currentPage = this.currentPage + this.activitiesAmount;
      this.endIndex += this.activitiesAmount;
    }
    
    this.activitiesToShow = this.boardActivities.slice(this.currentPage, this.endIndex);
  };
}
