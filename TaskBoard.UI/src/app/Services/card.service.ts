import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { Observable, catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardService {

  constructor(private http: HttpClient) {}

  getCards(): Observable<ICard[]> {
    return this.http.get<ICard[]>('/api/Cards');
  }

  createCard(cardToCreate: ICard) : Observable<ICard> {
    return this.http.post<ICard>('api/Cards?Listid=1', cardToCreate);
  }
}
