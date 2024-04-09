import { Component, OnInit } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { BsModalService, ModalModule } from 'ngx-bootstrap/modal';
import { TooltipModule } from 'ngx-bootstrap/tooltip';

import { ResponsavelService } from '../../services/responsavel.service';
import { TituloComponent } from '../../shared/titulo/titulo.component';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-responsaveis',
  standalone: true,
  imports: [
    NgFor,
    NgIf,
    FormsModule,
    TooltipModule,
    ModalModule,
    TituloComponent,
    RouterOutlet,
    RouterLink,
    RouterLinkActive,
  ],
  templateUrl: './responsaveis.component.html',
  styleUrls: ['../../app.component.scss'],
  providers: [ResponsavelService, BsModalService],
})
export class ResponsaveisComponent implements OnInit {
  ngOnInit(): void {}
}
