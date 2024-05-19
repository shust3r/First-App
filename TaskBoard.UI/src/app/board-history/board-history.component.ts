import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-board-history',
  templateUrl: './board-history.component.html',
  styleUrl: './board-history.component.css'
})
export class BoardHistoryComponent {
  @Input() hideBtn : boolean;

  switchHistory() {
    this.hideBtn = true;
  }
}
