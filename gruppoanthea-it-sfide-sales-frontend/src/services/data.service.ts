import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Article } from 'src/models/article';
import { Observable } from 'rxjs';
import { Cart } from 'src/models/cart';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getArticles(): Observable<Article[]> {
    return this.http.get<Article[]>("https://localhost:44343/api/Article/GetArticles");
  }

  printReceipt(carts: Cart[]): Observable<Cart[]> {
    const headers = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');
    return this.http.post<Cart[]>("https://localhost:44343/api/Article/PrintReceipt", JSON.stringify(carts), { headers: headers });
  }
}
