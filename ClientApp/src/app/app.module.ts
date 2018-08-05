import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppRoutingModule } from './app-routing.module';
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
import { HeightMatchDirective } from './shared/directives/heightMatch/height-match.directive';
import { InfoComponent } from './info/info.component';

import { AppService } from './app.service';

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
    HeightMatchDirective,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    HttpClientModule,
  ],
  providers: [AppService],
  bootstrap: [AppComponent],
})
export class AppModule {}
