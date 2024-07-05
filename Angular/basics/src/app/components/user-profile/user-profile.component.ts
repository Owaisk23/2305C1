import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-user-profile',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
  name = "Owais Ahmed Khan";
  salary = 56000;
  designation = "Software Developer";
  isDisabled= true;
  inputVal = "test";
  users = [
    {name:"Owais", isSingle:true, salary:1000},
    {name:"Abdullah", isSingle:false, salary:123000},
    {name:"Taha", isSingle:true, salary:3000},
    {name:"Bilal", isSingle:false, salary:15000},
  ]

  // onChange(){
  //   console.log("Called Function");
  // }

  // onChange(e:Event){
  //   const value = (e.target as HTMLInputElement).value;
  //   console.log(value);
  // }

  onChange(e:Event){
    const value = (e.target as HTMLInputElement).value;
    this.inputVal = value;
  }


}
