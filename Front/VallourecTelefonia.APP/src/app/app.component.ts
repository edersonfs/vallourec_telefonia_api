import { Component } from '@angular/core';
import {
  RouterLink,
  RouterLinkActive,
  RouterModule,
  RouterOutlet,
} from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';

import { NavComponent } from './shared/nav/nav.component';

import { ResponsavelService } from './services/responsavel.service';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  imports: [
    CommonModule,
    RouterOutlet,
    RouterModule,
    RouterLink,
    RouterLinkActive,
    NavComponent,
    HttpClientModule,
    NgxSpinnerModule,
  ],
  providers: [ResponsavelService, ToastrService],
})
export class AppComponent {
  title = 'VallourecTelefonia.APP';
}
