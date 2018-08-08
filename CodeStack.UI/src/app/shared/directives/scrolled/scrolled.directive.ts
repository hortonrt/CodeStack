import { Directive, HostBinding } from '@angular/core';

@Directive({
  selector: '[appScrolled]',
})
export class ScrolledDirective {
  @HostBinding('class.scrolled') shadow: boolean;
  constructor() {}

  ngOnInit() {
    if (typeof window !== undefined) {
      window.addEventListener('scroll', () => this._checkScroll());
    }
  }

  ngOnDestroy() {
    if (typeof window !== undefined) {
      window.removeEventListener('scroll', () => this._checkScroll());
    }
  }

  private _checkScroll() {
    if (typeof window !== undefined) {
      this.shadow = window.pageYOffset > 80;
    }
  }
}
