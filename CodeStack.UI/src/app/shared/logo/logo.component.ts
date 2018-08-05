import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'cs-logo',
  templateUrl: './logo.component.html',
  styleUrls: ['./logo.component.scss'],
})
export class LogoComponent implements OnInit {
  @Input() size?: string;
  @Input() color?: string;
  @Input() white?: boolean;
  whiteflag: boolean;
  constructor() {}

  ngOnInit() {
    this.whiteflag = !!this.white;
  }
}
