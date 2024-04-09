using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.Repository.Contracts;

public interface IResponsavelRepository
{
    Task<Responsavel[]> GetAllResponsaveisAsync();
    Task<Responsavel> GetResponsavelByIdAsync(int id);
}
