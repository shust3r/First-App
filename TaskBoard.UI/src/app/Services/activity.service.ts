import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IActivity } from '../Interfaces/IActivity';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  constructor(private http: HttpClient) { }

  getActivities(): Observable<IActivity[]> {
    return this.http.get<IActivity[]>('api/activities');
  }

  // getActivitiesById(cardId: number): Observable<IActivity[]> {
  //   return this.http.get<IActivity[]>('api/activities/' + cardId);
  // }
}
