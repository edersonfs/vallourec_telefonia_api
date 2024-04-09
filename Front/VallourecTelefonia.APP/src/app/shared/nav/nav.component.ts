import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { provideAnimations } from '@angular/platform-browser/animations';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [
    CollapseModule,
    CommonModule,
    BsDropdownModule,
    RouterLink,
    RouterLinkActive,
  ],
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss', '../../app.component.scss'],
  providers: [provideAnimations()],
})
export class NavComponent implements OnInit {
  isCollapsed = true;

  constructor(private router: Router) {
    provideAnimations();
  }

  ngOnInit() {}

  navClick(isCollapsed: boolean) {
    this.isCollapsed = !isCollapsed;
  }

  public getCollapsed(): any {
    return this.isCollapsed;
  }

  showMenu(): boolean {
    return this.router.url !== '/user/login';
  }
}
