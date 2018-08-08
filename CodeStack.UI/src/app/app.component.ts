import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  size = '50px';
  activeRoute = 'section1';

  constructor() {}

  onSectionChange(sectionId: string) {
    this.activeRoute = sectionId || 'main';
  }
}
