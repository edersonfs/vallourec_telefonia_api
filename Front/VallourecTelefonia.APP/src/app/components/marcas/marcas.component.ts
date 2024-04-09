import { Component, OnInit } from '@angular/core';

import { TituloComponent } from '../../shared/titulo/titulo.component';

@Component({
  selector: 'app-marcas',
  standalone: true,
  imports: [TituloComponent],
  templateUrl: './marcas.component.html',
  styleUrls: ['./marcas.component.scss'],
})
export class MarcasComponent implements OnInit {
  constructor() {}

  ngOnInit() {}
}
