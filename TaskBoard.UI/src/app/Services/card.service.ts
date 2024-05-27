import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  constructor(private http: HttpClient) {}

  getCards(): Observable<ICard[]> {
    return this.http.get<ICard[]>('/api/Cards');
  }

  //TODO: Fix this method
  getCardById(cardId: number): Observable<ICard> {
    // const get = `/api/Cards/${cardId}`;
    return this.http.get<ICard>("/api/Cards/13");
  }

  createCard(cardToCreate: ICard) : Observable<ICard> {
    return this.http.post<ICard>('api/Cards?Listid=1', cardToCreate);
  }

  // moveCard(cardId: number, listId: number) {
  //   this.http.patch('api/Cards/6', 
  //     {
  //       "operationType": 0,
  //       "path": "listId",
  //       "op": "replace",
  //       "value": "3"
  //     });
  // }
}