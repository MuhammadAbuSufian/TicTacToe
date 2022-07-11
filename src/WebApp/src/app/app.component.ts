import { Component } from '@angular/core';
import {AppService} from "./app.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'WebApp';
  scratches: any[] = []
  private readonly userId: number = Math.floor(Math.random()*90000) + 10000;
  constructor(private appService: AppService) {
  }

  ngOnInit(): void {
    // this.getData();
  }

  getData(){
    this.appService.getData().subscribe((scratches: any) => {
      this.scratches = scratches;
    })
  }

  scratch(index: number){
    // this.scratches[index].userId = this.userId;
    // this.appService.updateData(this.scratches[index]).subscribe(()=>{})
  }

  counter(i: number) {
    return new Array(i);
  }
}
