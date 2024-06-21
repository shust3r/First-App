import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Board } from '../Interfaces/board';

@Injectable({
  providedIn: 'root'
})
export class BoardService {
  openedBoard: Board = {
    id: -1,
    name: "",
    lists: null };
  constructor(private http: HttpClient) { }

  getAll(): Observable<Board[]> {
    return this.http.get<Board[]>('api/Boards');
  }

  getById(id: number): Observable<Board> {
    return this.http.get<Board>(`api/Boards/${id}`);
  }

  create(name: string): Observable<Board> {
    return this.http.post<Board>(`api/Boards/`, {"name": `${name}`});
  }

  rename(name:string, id: number) {
    this.http.patch<Board>(`api/Boards/${id}`,
      [{
        "operationType": 0,
        "path": "Name",
        "op": "replace",
        "value": `${name}`
      }]).subscribe();
  }

  delete(id: number) {
    this.http.delete(`api/Boards/${id}`).subscribe();
  }
}
