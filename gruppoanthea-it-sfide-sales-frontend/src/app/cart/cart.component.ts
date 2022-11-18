import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Cart } from 'src/models/cart';
import { DataService } from 'src/services/data.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent {
  @Input('carts') carts?: Cart[];
  @Output() closeCartEvent = new EventEmitter<void>();
  
  constructor(public data: DataService) { }

  ngOnInit() {          
    this.data.printReceipt(this.carts!)
    .subscribe(data => {
        this.carts = data;
    });
  }
  
  getSalesTaxes() {
    const sum = this.carts!.reduce((accumulator, object) => {
      return accumulator + object.salesTaxes!;
    }, 0);

    return sum;
  }
  
  getTotal() {
    const sum = this.carts!.reduce((accumulator, object) => {
      return accumulator + object.price!;
    }, 0);

    return sum;
  }
}