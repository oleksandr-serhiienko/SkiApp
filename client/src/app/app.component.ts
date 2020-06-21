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
  products: any[];

  constructor(private http: HttpClient) { }
    
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/products?pageSize=50').subscribe((response: any) => {
      console.log(response);
      this.products = response.date;
    }, error => {
      console.log(error);
    });
  }
}

