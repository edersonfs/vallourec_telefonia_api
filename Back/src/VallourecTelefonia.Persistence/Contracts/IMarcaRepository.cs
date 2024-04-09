using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.Repository.Contracts;

public interface IMarcaRepository
{
    // MARCA
    Task<Marca[]> GetAllMarcasByModeloAsync(string modelo);
    Task<Marca[]> GetAllMarcasAsync();
    Task<Marca> GetMarcaByIdAsync(int id);
}
