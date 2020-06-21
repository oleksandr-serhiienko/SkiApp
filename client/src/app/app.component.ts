import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { createWriteStream } from 'fs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'SkiNet';

  constructor(private http: HttpClient) { }
    
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/products').subscribe((response: any) => {
      console.log(response);
    }, error => { console.log(error) });
    }
}
