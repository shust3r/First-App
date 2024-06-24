import { Component, Input } from '@angular/core';
import { IActivity } from '../Interfaces/IActivity';

@Component({
  selector: 'app-activity',
  templateUrl: './activity.component.html',
  styleUrl: './activity.component.css'
})
export class ActivityComponent {
  @Input() activity : IActivity;

  humanizeDate(d: Date) : string{
    const date: Date = new Date(d);
    return date.toDateString() + " at " + date.toLocaleTimeString();
  }

  getPriority(p: number): string {
    if (p == 1) return "Low";
    if (p == 2) return "Medium";
    if (p == 3) return "High";
  }
}