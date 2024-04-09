import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResponsavelListaComponent } from './responsavel-lista.component';

describe('ResponsavelListaComponent', () => {
  let component: ResponsavelListaComponent;
  let fixture: ComponentFixture<ResponsavelListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ResponsavelListaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ResponsavelListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
