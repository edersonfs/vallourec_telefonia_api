/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ResponsavelService } from './responsavel.service';

describe('Service: Responsavel', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ResponsavelService]
    });
  });

  it('should ...', inject([ResponsavelService], (service: ResponsavelService) => {
    expect(service).toBeTruthy();
  }));
});
