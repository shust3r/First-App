import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  hideHistory: boolean = false;
  

  switchHistory() {
    this.hideHistory = this.hideHistory == true ? false : true;
  }
}
