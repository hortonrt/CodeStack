import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { MainComponent } from './pages/main/main.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { PortfolioComponent } from './pages/portfolio/portfolio.component';
import { StackComponent } from './pages/stack/stack.component';
import { TestimonialsComponent } from './pages/testimonials/testimonials.component';
import { BannerComponent } from './shared/banner/banner.component';
import { BoxesComponent } from './shared/boxes/boxes.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HeaderComponent } from './shared/header/header.component';
import { LogoBannerComponent } from './shared/logo-banner/logo-banner.component';
import { LogoComponent } from './shared/logo/logo.component';
import { PageHeaderComponent } from './shared/page-header/page-header.component';
import { InfoComponent } from './shared/info/info.component';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { AlertModule } from 'ngx-bootstrap/alert';

import { AppService } from './app.service';
import { AppLogoComponent } from './shared/app-logo/app-logo.component';
import { ScrolledDirective } from './shared/directives/scrolled/scrolled.directive';
import { ScrollSpyDirective } from './shared/directives/scrollspy/scrollspy.directive';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    AboutComponent,
    ContactComponent,
    PortfolioComponent,
    StackComponent,
    TestimonialsComponent,
    BannerComponent,
    BoxesComponent,
    FooterComponent,
    HeaderComponent,
    LogoBannerComponent,
    LogoComponent,
    PageHeaderComponent,
    InfoComponent,
    AppLogoComponent,
    ScrolledDirective,
    ScrollSpyDirective,
  ],
  imports: [
    BrowserModule,
    FontAwesomeModule,
    FormsModule,
    HttpClientModule,
    CarouselModule.forRoot(),
    AlertModule.forRoot(),
  ],
  providers: [AppService],
  bootstrap: [AppComponent],
})
export class AppModule {}
