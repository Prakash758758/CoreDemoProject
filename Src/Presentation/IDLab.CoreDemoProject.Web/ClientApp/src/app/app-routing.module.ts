import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { ChangePasswordComponent } from './change-password/change-password.component';
import { LogOutComponent } from './log-out/log-out.component';
import { UnAthorizeComponent } from './un-athorize/un-athorize.component';


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignUpComponent },
  { path: 'forgot-password', component: ForgotPasswordComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'change-password', component: ChangePasswordComponent },
  { path: 'log-out', component: LogOutComponent },
  { path: 'un-athorize', component: UnAthorizeComponent },

  { path: '**', component: PageNotFoundComponent },
];

@NgModule({
  declarations: [


  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})


export class AppRoutingModule {

}
export const AppRoute = [
  HomeComponent,
  LoginComponent,
  ContactComponent,
  AboutComponent,
  ForgotPasswordComponent,
  SignUpComponent,
  ChangePasswordComponent,
  LogOutComponent,
  UnAthorizeComponent,
  PageNotFoundComponent
]
