import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };
  private rootpath: string = '/api/';
  constructor(private http: HttpClient) {}

  get(path: string) {
    return this.http.get(this.rootpath + path);
  }
  post(path: string, payload: any) {
    return this.http.post(this.rootpath + path, payload, this.httpOptions);
  }
}
