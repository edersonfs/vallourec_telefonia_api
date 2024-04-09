using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.Application.Contracts;

public interface IResponsavelService
{
    Task<Responsavel> AddResponsavel(Responsavel model);
    Task<Responsavel> UpdateResponsavel(int id, Responsavel model);
    Task<bool> DeleteResponsavel(int id);
    Task<Responsavel[]> GetAllResponsaveisAsync();
    Task<Responsavel> GetResponsavelByIdAsync(int id);
}
