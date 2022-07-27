import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Robot } from '../_models/Robot';

@Injectable({
  providedIn: 'root'
})
export class RobotsService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getRobots()
  {
    return this.http.get<Robot[]>(this.baseUrl + 'Robot');
  }

  getRobot(robotName: string) 
  {
    return this.http.get<Robot>(this.baseUrl + 'Robot/')

  }
}
