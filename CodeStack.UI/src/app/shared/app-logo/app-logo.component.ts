import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-logo',
  templateUrl: './app-logo.component.html',
  styleUrls: ['./app-logo.component.scss'],
})
export class AppLogoComponent implements OnInit {
  @Input() size: string;
  constructor() {}

  ngOnInit() {}
}
