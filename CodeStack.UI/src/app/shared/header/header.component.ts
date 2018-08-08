import { Component, OnInit, Input, SimpleChanges } from '@angular/core';
import { faBars, faTimes } from '@fortawesome/free-solid-svg-icons';
import { faLinkedin } from '@fortawesome/free-brands-svg-icons';

@Component({
  selector: 'cs-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  @Input() activeRoute: string;
  faBars = faBars;
  faTimes = faTimes;
  faLinkedin = faLinkedin;
  expanded = false;

  constructor() {
    this.activeRoute = 'main';
  }

  ngOnInit() {}

  ngOnChanges(changes: SimpleChanges) {
    this.activeRoute = changes.activeRoute.currentValue;
  }
  expand() {
    this.expanded = !this.expanded;
  }

  changeRoute(navRoute: string) {
    this.expanded = false;
    this.activeRoute = navRoute;
    let selector: string = '';
    if (navRoute === 'main') {
      selector = 'body';
    } else {
      selector = '#' + navRoute + '-anc';
    }
    document
      .querySelector(selector)
      .scrollIntoView({ block: 'start', behavior: 'smooth' });
  }
}
