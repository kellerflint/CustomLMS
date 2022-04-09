import { Component } from '@angular/core';
import { UserService } from './services/user.service';

import { SocialAuthService } from "angularx-social-login";
import { GoogleLoginProvider } from "angularx-social-login";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CustomLMSUI';

  test = '';

  constructor(private authService: SocialAuthService, private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getTestRes().subscribe(res => {
      this.test = res.word;
    });
  }

  signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
  }

  signOut(): void {
    this.authService.signOut();
  }
}
