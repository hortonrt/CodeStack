import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact';
import { AppService } from '../../app.service';
import { NgForm } from '../../../../node_modules/@angular/forms';
import { AlertComponent } from 'ngx-bootstrap/alert/alert.component';
import { faSpinner } from '../../../../node_modules/@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss'],
})
export class ContactComponent implements OnInit {
  contact: Contact = new Contact();
  alerts: any[] = [];
  faSpinner = faSpinner;
  sending: boolean = false;
  constructor(private service: AppService) {}

  ngOnInit() {}

  onSubmit(f: NgForm) {
    this.sending = true;
    this.service.post('Options/Contact', this.contact).subscribe((x) => {
      this.contact = Object.assign({}, new Contact());
      this.sending = false;
      this.add();
      f.resetForm();
    });
  }

  add(): void {
    this.alerts = Object.assign(
      [],
      [
        {
          type: 'success',
          msg: `Email has been sent! Thank you for contacting CODESTACK!`,
          timeout: 5000,
        },
      ],
    );
  }

  onClosed(dismissedAlert: AlertComponent): void {
    this.alerts = this.alerts.filter((alert) => alert !== dismissedAlert);
  }
}
