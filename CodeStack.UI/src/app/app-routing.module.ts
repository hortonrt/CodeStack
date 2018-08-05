import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './pages/main/main.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { StackComponent } from './pages/stack/stack.component';
import { TestimonialsComponent } from './pages/testimonials/testimonials.component';
import { PortfolioComponent } from './pages/portfolio/portfolio.component';

const routes: Routes = [
  { path: 'main', component: MainComponent },
  { path: 'about', component: AboutComponent },
  { path: 'stack', component: StackComponent },
  { path: 'testimonials', component: TestimonialsComponent },
  { path: 'portfolio', component: PortfolioComponent },
  { path: 'contact', component: ContactComponent },
  { path: '', redirectTo: '/main', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
