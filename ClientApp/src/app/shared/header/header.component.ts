import { Component, OnInit } from '@angular/core';
import { Router, Route } from '@angular/router';

import {
  faBars,
  faPhone,
  faGlobe,
  faEnvelope,
  faTimes,
} from '@fortawesome/free-solid-svg-icons';
import { NavRoute } from '../../models/nav-route';
import { AppService } from '../../app.service';

@Component({
  selector: 'cs-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  faBars = faBars;
  faPhone = faPhone;
  faGlobe = faGlobe;
  faEnvelope = faEnvelope;
  faTimes = faTimes;
  expanded = false;
  activeRoute = 'Main';
  mainRoute = {
    NavRouteID: -1,
    Details: '',
    Name: 'MAIN',
    Routerlink: 'main',
  };
  navOptions: NavRoute[] = [];
  constructor(private router: Router, private service: AppService) {}

  ngOnInit() {
    this.service.get('Options/Routes').subscribe((routes: NavRoute[]) => {
      this.navOptions = routes;
    });
  }

  expand() {
    this.expanded = !this.expanded;
  }

  changeRoute(navRoute: NavRoute) {
    this.expanded = false;
    this.activeRoute = navRoute.Name;
    this.router.navigate(['/' + navRoute.Routerlink]);
  }
}
