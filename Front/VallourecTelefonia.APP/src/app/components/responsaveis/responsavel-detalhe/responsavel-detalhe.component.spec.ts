import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResponsavelDetalheComponent } from './responsavel-detalhe.component';

describe('ResponsavelDetalheComponent', () => {
  let component: ResponsavelDetalheComponent;
  let fixture: ComponentFixture<ResponsavelDetalheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ResponsavelDetalheComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ResponsavelDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
