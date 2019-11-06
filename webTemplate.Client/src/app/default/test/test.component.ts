import { Component, OnInit } from '@angular/core';
import { IntService } from 'src/app/models/services/int.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.scss']
})
export class TestComponent implements OnInit {

  constructor(private intService : IntService) { }

  log : string;

  ngOnInit() {

    // this.get();
    // this.getItem();
    // this.post();
    // this.put();
    // this.delete();
  }

  get() {
    this.intService.getAll().subscribe(i => {
      console.log("Int GetAll", i);
    })
  }

  getItem() {
    let input = 1;
    console.log("Int Get REQUEST", input);
    this.intService.get(input).subscribe(res => {
      console.log("Int Get RESPONSE", res);
    })
  }

  post() {
    let input = 2;
    console.log("Int Post REQUEST ", input);
    this.intService.post(input).subscribe(res => {
      console.log("Int Post RESPONSE", res);
    })
  }
   
  put() {
    let input = 3;
    console.log("Int PUT REQUEST ", input);
    this.intService.put(input).subscribe(res => {
      console.log("Int PUT RESPONSE", res);
    })
  }

  delete() {
    let input = 4;
    console.log("Int DELETE REQUEST ", input);
    this.intService.delete(input).subscribe(res => {
      console.log("Int DELETE RESPONSE", res);
    })
  }
}
