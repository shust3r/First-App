import { Component, Input, OnInit } from '@angular/core';
import { IActivity } from '../Interfaces/iactivity';
import { ActivityService } from '../Services/activity.service';


@Component({
  selector: 'app-board-history',
  templateUrl: './board-history.component.html',
  styleUrl: './board-history.component.css'
})
export class BoardHistoryComponent implements OnInit {
  @Input() hideBtn : boolean;
  activities: IActivity[];

  constructor(
    private actSvc: ActivityService
  ) {}

  ngOnInit(): void {
    this.actSvc.getActivities().subscribe(response => {
      this.activities = response;
    });
  }

  switchHistory() {
    this.hideBtn = true;
  }
}
