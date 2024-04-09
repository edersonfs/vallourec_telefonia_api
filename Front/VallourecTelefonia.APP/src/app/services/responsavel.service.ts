import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Responsavel } from '../models/Responsavel';

@Injectable()
// {providedIn: 'root', }
export class ResponsavelService {
  baseURL = 'http://localhost:5111/api/responsavel';

  constructor(private http: HttpClient) {}

  public getResponsaveis(): Observable<Responsavel[]> {
    return this.http.get<Responsavel[]>(this.baseURL);
  }

  public getResponsaveisById(id: number): Observable<Responsavel> {
    return this.http.get<Responsavel>(`${this.baseURL}/${id}`);
  }
}
