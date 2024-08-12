import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms'
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
     FormsModule, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'crud';

  constructor(private http: HttpClient){

  }

  onProductCreate(products: {
    pName: string,
    desc: string,
    price: string
  }){
    console.log(products)
    this.http.post('https://crud-app-fbe09-default-rtdb.asia-southeast1.firebasedatabase.app/products.json', products)
    .subscribe((res) => {
      console.log(res)
    })
  }

}
