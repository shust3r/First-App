import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { Observable } from 'rxjs';
import { error } from 'node:console';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  constructor(private http: HttpClient) {}

  getCards(): Observable<ICard[]> {
    return this.http.get<ICard[]>('/api/Cards');
  }

  getCardById(cardId: number): Observable<ICard> {
    return this.http.get<ICard>(`/api/Cards/${cardId}`);
  }

  createCard(cardToCreate: ICard) : Observable<ICard> {
    return this.http.post<ICard>(`api/Cards?Listid=${cardToCreate.listId}`, cardToCreate);
  }

  moveCard(cardId: number, listId: number) {
    this.http.patch(`api/Cards/${cardId}`, 
    [{
        "operationType": '0',
        "path": "listId",
        "op": "replace",
        "value": `${listId}`
    }]).subscribe();
  }
}