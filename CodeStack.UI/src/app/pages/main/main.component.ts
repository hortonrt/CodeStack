import { Component, OnInit } from '@angular/core';

import {
  faGlobe,
  faTerminal,
  faDatabase,
  faHome,
  faCode,
  faTabletAlt,
  faDesktop,
  faMobileAlt,
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss'],
})
export class MainComponent implements OnInit {
  faGlobe = faGlobe;
  faTerminal = faTerminal;
  faDatabase = faDatabase;
  faHome = faHome;
  faCode = faCode;
  faPhone = faMobileAlt;
  faTablet = faTabletAlt;
  faDesktop = faDesktop;
  constructor() {}

  ngOnInit() {}
}
