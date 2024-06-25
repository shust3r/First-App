import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IActivity } from '../Interfaces/IActivity';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  constructor(private http: HttpClient) { }

  getActivities(boardId: number): Observable<IActivity[]> {
    return this.http.get<IActivity[]>(`api/Activities?boardId=${boardId}`);
  }

  getCardActivities(cardId: number): Observable<IActivity[]> {
    return this.http.get<IActivity[]>(`api/Activities?cardId=${cardId}`);
  }
}
