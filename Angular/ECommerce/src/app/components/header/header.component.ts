import { Component, OnInit, signal } from '@angular/core';
import { count } from 'rxjs';

@Component({
  selector: 'app-header',
  standalone: false,
  
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})

export class HeaderComponent implements OnInit  {
  counter = signal(0);
  userName = "Jagadeesh";
  form! : FormData;
  ngOnInit(): void {
    this.UpdateCounter();
  }
   UpdateCounter() {
     this.counter.update(count=> count+1);
     console.log(this.counter());
  }

}
