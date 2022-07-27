import { Component, OnInit } from '@angular/core';
import { Robot } from 'src/app/_models/Robot';
import { RobotsService } from 'src/app/_services/robots.service';

@Component({
  selector: 'app-build-maker',
  templateUrl: './build-maker.component.html',
  styleUrls: ['./build-maker.component.css']
})
export class BuildMakerComponent implements OnInit {
  robots: Robot[];

  constructor(private robotService: RobotsService) { }

  ngOnInit(): void {
    this.loadRobots();
  }

  loadRobots()
  {
    this.robotService.getRobots().subscribe(robots => {this.robots = robots;})
  }

}
