import { Component } from '@angular/core';
import { Article } from 'src/models/article';
import { Cart } from 'src/models/cart';
import { DataService } from 'src/services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  articles: Article[] = [];
  carts: Cart[] = [];
  showCart: boolean = false;

  constructor(public data: DataService) {}

  ngOnInit() {          
    this.data.getArticles()
    .subscribe(data => {
        this.articles = data;
    });
  }

  addToCart(article: Article) {
    var index = this.carts.findIndex((c => c.article!.id === article.id));

    if(index == -1) {
      this.carts.push({ article: article, quantity: 1, price: 0 });
    }
    else {
      this.carts[index].quantity!++;
    }
  }

  removeFromCart(article: Article) {
    var index = this.carts.findIndex((c => c.article!.id === article.id));

    if(index != -1 && this.carts[index].quantity! > 0) {
      this.carts[index].quantity!--;
      
      if(this.carts[index].quantity! <= 0) {
        this.carts.splice(index, 1);
      }
    }
  }

  getCartQuantity() {
    const sum = this.carts.reduce((accumulator, object) => {
      return accumulator + object.quantity!;
    }, 0);

    return sum;
  }

  closeCart() {
    this.showCart = false;
  }
}
