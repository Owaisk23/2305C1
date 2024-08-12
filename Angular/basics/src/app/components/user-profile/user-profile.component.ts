import { CommonModule } from '@angular/common';
import { booleanAttribute, Component, numberAttribute, Input, Output, EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from '../../../models/user';


@Component({
  selector: 'app-user-profile',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
  @Input({alias:"userName"}) name = "";
  @Input({transform:booleanAttribute}) isSingle!:boolean;
  @Input({transform: numberAttribute}) salary!:number;

  @Output() myEvent = new EventEmitter<User>()
  sendData(){
    this.myEvent.emit({name:this.name, newSalary: 25000})
  }

  // name = "Owais Ahmed Khan";
  // salary = 56000;
  // designation = "Software Developer";
  // isDisabled= true;
  // inputVal = "test";
  

  onChange(){
    console.log("Called Function");
  }

  onChange(e:Event){
    const value = (e.target as HTMLInputElement).value;
    console.log(value);
  }

  onChange(e:Event){
    const value = (e.target as HTMLInputElement).value;
    this.inputVal = value;
  }


}
