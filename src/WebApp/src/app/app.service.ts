import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {environment} from "../environments/environment";
import {MoveModel} from "./move.model";

@Injectable({
  providedIn: 'root'
})
export class AppService{
  constructor(private http: HttpClient) {
  }

  initializeGame(){
    const url = environment.baseUrl + 'Game/Initialize';
    return this.http.get(url);
  }

  pleyMove(data: MoveModel){
    const url = environment.baseUrl + 'Game/Play';
    return this.http.post(url, data);
  }
}
