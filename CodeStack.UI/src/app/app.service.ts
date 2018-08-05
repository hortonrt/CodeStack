import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  private rootpath: string = '/api/';
  constructor(private http: HttpClient) {}

  get(path: string) {
    return this.http.get(this.rootpath + path);
  }
}
