import { CommonModule, NgIf } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-titulo',
  standalone: true,
  imports: [NgIf, CommonModule],
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss'],
})
export class TituloComponent implements OnInit {
  @Input() titulo: string = '';
  @Input() iconClass: string = '';
  @Input() subtitulo: string = '';
  @Input() botaoListar: boolean = false;

  constructor(private router: Router) {}

  ngOnInit() {}

  listar(): void {
    this.router.navigate([`/${this.titulo.toLowerCase()}/lista`]);
  }
}
