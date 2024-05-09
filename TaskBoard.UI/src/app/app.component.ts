import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'TaskBoard.UI';
  lists: any;
  cards: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getLists();
    this.getCards();
  }

  getLists() {
    this.http.get('https://localhost:7202/api/Lists')
    .subscribe(response => {
        this.lists = response;
      }, error => {
        console.log(error);
      });
  }

  getCards() {
    this.http.get('https://localhost:7202/api/Cards')
    .subscribe(response => {
        this.cards = response;
      }, error => {
        console.log(error);
      });
  }
}
