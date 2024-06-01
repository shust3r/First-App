import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IList } from '../Interfaces/IList';
import { IListNameId } from '../Interfaces/IListNameId';

@Injectable({
  providedIn: 'root'
})
export class ListService {

  constructor(private http: HttpClient) { }

  getLists(): Observable<IList[]> {
    return this.http.get<IList[]>('/api/Lists');
  }

  getListNamesWithIds(): Observable<IListNameId[]> {
    return this.http.get<IListNameId[]>('/api/Lists/Names');
  }

  createList(name: string) {
    return this.http.post<IList>(`api/Lists`, {"name": `${name}`});
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
