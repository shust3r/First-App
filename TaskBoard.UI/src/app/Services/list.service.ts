import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IList } from '../Interfaces/IList';

@Injectable({
  providedIn: 'root'
})
export class ListService {

  constructor(private http: HttpClient) { }

  getLists(boardId: number): Observable<IList[]> {
    return this.http.get<IList[]>(`/api/Lists/${boardId}`);
  }

  createList(name: string, boardId: number) {
    return this.http.post<IList>(`api/Lists/${boardId}`, {"name": `${name}`});
  }

  renameList(name: string, id: number) {
    this.http.patch<IList>(`api/Lists/${id}`,
    [{
      "operationType": 0,
      "path": "Name",
      "op": "replace",
      "value": `${name}`
    }]).subscribe();
  }

  deleteListById(listId: number) {
    this.http.delete(`api/Lists/${listId}`).subscribe();
  }
}
