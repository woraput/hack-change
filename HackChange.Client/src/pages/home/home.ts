import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  pay: number;
  amount: number;
  change: any = 0;
  banks: any = [];
  banksList: any = [1000,500,100,50,20,5,1];
  status: any = 3;

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  Buy() {
    this.http.get<any>("https://hackathon-money.azurewebsites.net/api/changemoney/" + this.amount + "/" + this.pay)
      .subscribe(data => {
        this.banks = data.bankCards;
        this.change = data.change;
        this.status = data.statusCode;
      });
  }

}
