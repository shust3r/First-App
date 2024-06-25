import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { IActivity } from '../Interfaces/IActivity';
import { ActivityService } from '../Services/activity.service';

@Component({
  selector: 'app-board-history',
  templateUrl: './board-history.component.html',
  styleUrl: './board-history.component.css'
})
export class BoardHistoryComponent implements OnChanges {
  @Input() boardId : number;
  boardActivities: IActivity[] = [];
  activitiesToShow: IActivity[] = [];
  currentPage: number = 0;
  activitiesAmount: number = 6;
  endIndex: number = this.activitiesAmount;
  isOpened: boolean = false;

  constructor(private actSvc: ActivityService) { }

  ngOnChanges(changes: SimpleChanges): void {
    this.loadActivities(this.boardId);
  }

  openHistory() {
    this.showMore();
    this.isOpened = true;
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
      this.currentPage += this.activitiesAmount;
      this.endIndex += this.activitiesAmount;
    }

    this.activitiesToShow = this.boardActivities
      .slice(this.currentPage, this.endIndex);
  };
}
