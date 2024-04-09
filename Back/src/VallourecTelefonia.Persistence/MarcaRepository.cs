using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;
using VallourecTelefonia.Repository.Contexts;
using VallourecTelefonia.Repository.Contracts;

namespace VallourecTelefonia.Repository;

public class MarcaRepository : IMarcaRepository
{
    private readonly VallourecTelefoniaContext _context;
    public MarcaRepository(VallourecTelefoniaContext context)
    {
        this._context = context;
    }

    public Task<Marca[]> GetAllMarcasAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task<Marca[]> GetAllMarcasByModeloAsync(string modelo)
    {
        throw new System.NotImplementedException();
    }

    public Task<Marca> GetMarcaByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }
}
