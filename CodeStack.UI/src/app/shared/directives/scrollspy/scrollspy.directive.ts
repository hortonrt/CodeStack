import {
  Directive,
  EventEmitter,
  Output,
  ElementRef,
  HostListener,
  Input,
} from '@angular/core';

@Directive({
  selector: '[appScrollspy]',
})
export class ScrollSpyDirective {
  spiedTags = [];
  @Output() sectionChange = new EventEmitter<string>();
  private currentSection: string;

  constructor(private el: ElementRef) {
    this.spiedTags = ['APP-LOGO'];
  }

  ngOnInit() {
    if (typeof window !== undefined) {
      window.addEventListener('scroll', (e) => this.onScroll(e));
    }
  }

  ngOnDestroy() {
    if (typeof window !== undefined) {
      window.removeEventListener('scroll', (e) => this.onScroll(e));
    }
  }

  @HostListener('scroll', ['$event'])
  onScroll(event: any) {
    let currentSection: string;
    const children = this.el.nativeElement.children;
    const scrollTop = event.target.scrollingElement.scrollTop;
    const parentOffset = event.target.scrollingElement.offsetTop;
    for (const child of children) {
      if (this.spiedTags.some((spiedTag) => spiedTag === child.tagName)) {
        if (child.offsetTop - parentOffset <= scrollTop) {
          currentSection = child.id;
        }
      }
    }
    if (currentSection !== this.currentSection) {
      this.currentSection = currentSection;
      this.sectionChange.emit(this.currentSection);
    }
  }
}
