import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, UserProfileComponent,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  users = [
    {name:"Owais", isSingle:true, salary:1000},
    {name:"Abdullah", isSingle:false, salary:123000},
    {name:"Taha", isSingle:true, salary:3000},
    {name:"Bilal", isSingle:false, salary:15000},
  ]

  recevedData(data: string){
    console.log(data)
  }
}
