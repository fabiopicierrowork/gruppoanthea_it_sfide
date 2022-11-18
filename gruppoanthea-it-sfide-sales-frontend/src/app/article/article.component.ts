import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Article } from 'src/models/article';

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrls: ['./article.component.scss']
})
export class ArticleComponent {
  @Input('article') article?: Article;
  @Output() addToCartEvent = new EventEmitter<Article>();
  @Output() removeFromCartEvent = new EventEmitter<Article>();
  quantity: number = 0;

  addToCart(article: Article) {
    this.quantity++;
    this.addToCartEvent.emit(article);
  }

  removeFromCart(article: Article) {
    this.quantity--;
    this.removeFromCartEvent.emit(article);
  }
}
