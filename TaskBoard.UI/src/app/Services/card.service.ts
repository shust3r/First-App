import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICard } from '../Interfaces/ICard';
import { Observable } from 'rxjs';
import { ICardPatch } from '../Interfaces/ICardPatch';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  constructor(private http: HttpClient) {}

  getCards(listId: number): Observable<ICard[]> {
    return this.http.get<ICard[]>(`/api/Cards?listId=${listId}`);
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

  changeCard(newCard: ICard, oldCard: ICard) {
    let operationCount = 0;
    let patches: ICardPatch[] = [];

    if(newCard.name != oldCard.name)
      {
        let dueD: ICardPatch = {
          operationType: operationCount,
          path: "Name",
          op: "replace",
          value: `${newCard.name}`
        }
        operationCount++;
        patches.push(dueD);
      }
    if(newCard.listId != oldCard.listId)
      {
        let dueD: ICardPatch = {
          operationType: operationCount,
          path: "listId",
          op: "replace",
          value: `${newCard.listId}`
        }
        operationCount++;
        patches.push(dueD);
      }
    if(newCard.priority != oldCard.priority)
      {
        let dueD: ICardPatch = {
          operationType: operationCount,
          path: "Priority",
          op: "replace",
          value: `${newCard.priority}`
        }
        operationCount++;
        patches.push(dueD);
      }
    if(newCard.description != oldCard.description)
      {
        let dueD: ICardPatch = {
          operationType: operationCount,
          path: "Description",
          op: "replace",
          value: `${newCard.description}`
        }
        operationCount++;
        patches.push(dueD);
      }
    if(newCard.dueDate != undefined && newCard.dueDate != oldCard.dueDate)
      {
        let dueD: ICardPatch = {
          operationType: operationCount,
          path: "dueDate",
          op: "replace",
          value: `${newCard.dueDate}`
        }
        patches.push(dueD);
      }
    
    this.http.patch(`api/Cards/${oldCard.id}`, patches).subscribe();
  }
  
  deleteCard(id: number) {
    this.http.delete(`api/Cards/${id}`).subscribe();
  }
}