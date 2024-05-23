import { Component, Input, OnInit, Output } from '@angular/core';
import { IActivity } from '../Interfaces/IActivity';
import { ActivityService } from '../Services/activity.service';


@Component({
  selector: 'app-board-history',
  templateUrl: './board-history.component.html',
  styleUrl: './board-history.component.css'
})
export class BoardHistoryComponent implements OnInit {
  @Input() hideBtn : boolean;
  activities: IActivity[] = [];
  activitiesToShow: IActivity[] = [];
  currentPage: number = 0;
  activitiesAmount: number = 7;
  endIndex: number = this.activitiesAmount;

  constructor(
    private actSvc: ActivityService
  ) {}

  ngOnInit(): void {
    this.actSvc.getActivities().subscribe(response => {
      this.activities = response;
    });

    this.showMore();
  }

  switchHistory() {
    this.hideBtn = true;
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
    
    this.activitiesToShow = this.activities.slice(this.currentPage, this.endIndex);
  };
}
