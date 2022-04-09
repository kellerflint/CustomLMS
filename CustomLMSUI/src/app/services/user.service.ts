import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TestObject } from '../models/TestObject';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getTestRes(): Observable<TestObject> {
    return this.http.get<TestObject>('https://localhost:7083/home');
  }
}
