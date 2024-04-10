import { CommonModule, NgClass, NgIf } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  FormControl,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-responsavel-detalhe',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, NgClass, NgIf],
  templateUrl: './responsavel-detalhe.component.html',
  styleUrl: './responsavel-detalhe.component.scss',
})
export class ResponsavelDetalheComponent implements OnInit {
  form: FormGroup = new FormGroup({});

  // get f(): any {
  //   return this.form.controls;
  // }

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.validation();
  }

  public validation(): void {
    this.form = this.formBuilder.group({
      nome: [
        '',
        [
          Validators.required,
          Validators.minLength(4),
          Validators.maxLength(100),
        ],
      ],
      email: ['', [Validators.required, Validators.email]],
      senha: ['', Validators.required],
      ativo: [false],
    });
  }

  resetForm(event: MouseEvent): void {
    event.preventDefault();
    this.form.reset();
  }
}
