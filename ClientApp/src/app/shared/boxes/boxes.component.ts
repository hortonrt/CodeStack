import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-boxes',
  templateUrl: './boxes.component.html',
  styleUrls: ['./boxes.component.scss'],
})
export class BoxesComponent implements OnInit {
  @Input() position: string;
  constructor() {}

  ngOnInit() {}
}
