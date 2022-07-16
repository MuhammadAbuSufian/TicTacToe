import {Component, OnInit} from '@angular/core';
import {AppService} from "./app.service";
import {MoveModel} from "./move.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'WebApp';
  scratches: any[] = [];
  game: any;
  player?: any;
  private readonly userId: number = Math.floor(Math.random()*90000) + 10000;
  constructor(private appService: AppService) {
  }

  ngOnInit(): void {
    this.initialize()
  }

  initialize(){
    this.appService.initializeGame().subscribe((game: any) => {
      this.game = game;
    });
  }

  fillCell(xAccess: any = null, yAccess: any = null){
    let moveRequest: MoveModel = new MoveModel();
    moveRequest.playerId = this.game.activePlayer.id;
    if (xAccess != null)
      moveRequest.coordinates = [xAccess, yAccess];
    this.appService.pleyMove(moveRequest).subscribe((game: any)=> {
      this.game = game;
      if (this.game.winner != null){
        alert('winner ' +  this.game.winner.name)
      }
    });
  }

  counter(i: number) {
    return new Array(i);
  }
}
