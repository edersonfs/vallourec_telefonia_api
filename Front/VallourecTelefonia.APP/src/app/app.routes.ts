import { Routes } from '@angular/router';

import { MarcasComponent } from './components/marcas/marcas.component';
import { ResponsaveisComponent } from './components/responsaveis/responsaveis.component';
import { ResponsavelListaComponent } from './components/responsaveis/responsavel-lista/responsavel-lista.component';
import { ResponsavelDetalheComponent } from './components/responsaveis/responsavel-detalhe/responsavel-detalhe.component';
import { UserComponent } from './components/user/user.component';
import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { PerfilComponent } from './components/user/perfil/perfil.component';

export const routes: Routes = [
  { path: '', component: ResponsaveisComponent },
  { path: 'responsaveis', redirectTo: 'responsaveis/lista' },
  {
    path: 'responsaveis',
    component: ResponsaveisComponent,
    children: [
      { path: 'detalhe/:id', component: ResponsavelDetalheComponent },
      { path: 'detalhe', component: ResponsavelDetalheComponent },
      { path: 'lista', component: ResponsavelListaComponent },
    ],
  },
  { path: 'user/perfil', title: 'perfil', component: PerfilComponent },
  { path: 'marcas', title: 'marcas', component: MarcasComponent },
  {
    path: 'user',
    title: 'user',
    component: UserComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'registration', component: RegistrationComponent },
    ],
  },
  { path: '**', redirectTo: '' },
];
