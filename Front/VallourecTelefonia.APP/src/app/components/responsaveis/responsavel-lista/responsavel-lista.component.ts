import { Component, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService, ModalModule } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { ResponsavelService } from '../../../services/responsavel.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { Responsavel } from '../../../models/Responsavel';
import { FormsModule } from '@angular/forms';
import { NgFor, NgIf } from '@angular/common';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { TituloComponent } from '../../../shared/titulo/titulo.component';
import {
  Router,
  RouterLink,
  RouterLinkActive,
  RouterOutlet,
} from '@angular/router';

@Component({
  selector: 'app-responsavel-lista',
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
  templateUrl: './responsavel-lista.component.html',
  styleUrl: './responsavel-lista.component.scss',
})
export class ResponsavelListaComponent {
  modalRef?: BsModalRef;

  constructor(
    private toastr: ToastrService,
    private responsavelService: ResponsavelService,
    private modalService: BsModalService,
    private spinner: NgxSpinnerService,
    private router: Router
  ) {}

  public ngOnInit(): void {
    this.spinner.show();
    this.getResponsaveis();
  }

  public responsaveis: Responsavel[] = [];
  public responsaveisFiltrados: Responsavel[] = [];

  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.responsaveisFiltrados =
      this.filtroLista !== ''
        ? this.filtrarResponsaveis(this.filtroLista)
        : this.getResponsaveis();
  }

  public filtrarResponsaveis(filtrarPor: string): Responsavel[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.responsaveis.filter(
      (res: any) => res.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  public getResponsaveis(): any {
    this.responsavelService.getResponsaveis().subscribe({
      next: (response: Responsavel[]) => {
        this.responsaveis = response;
        this.responsaveisFiltrados = response;
      },
      error: (error: any) => {
        this.spinner.hide();
        this.toastr.error(
          'Ocorreu um erro ao carregar os responsaveus',
          'Erro'
        );
      },
      complete: () => this.spinner.hide(),
    });
  }

  openModal(template: TemplateRef<void>): void {
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }

  confirm(): void {
    this.modalRef?.hide();
    this.toastr.success('O evento foi deletado com sucesso!', 'Deletado!');
  }

  decline(): void {
    this.modalRef?.hide();
  }

  detalheResponsavel(id: number): void {
    this.router.navigate([`responsaveis/detalhe/${id}`]);
  }
}
