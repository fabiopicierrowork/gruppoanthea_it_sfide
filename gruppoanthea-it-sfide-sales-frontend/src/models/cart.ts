import { Article } from "./article";

export class Cart {
    public article?: Article; 
    public quantity?: number;
    public salesTaxes?: number;
    public price: number = 0;
}