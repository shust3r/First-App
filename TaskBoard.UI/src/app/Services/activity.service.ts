import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IActivity } from '../Interfaces/IActivity';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  constructor(private http: HttpClient) { }

  //TODO: adjust the getActivities() to use the "boardId" variable
  getActivities(): Observable<IActivity[]> {
    return this.http.get<IActivity[]>('api/activities');
  }
}
