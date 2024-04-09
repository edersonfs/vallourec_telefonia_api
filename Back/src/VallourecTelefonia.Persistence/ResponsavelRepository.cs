using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;
using VallourecTelefonia.Repository.Contexts;
using VallourecTelefonia.Repository.Contracts;

namespace VallourecTelefonia.Repository;

public class ResponsavelRepository : IResponsavelRepository
{
    private readonly VallourecTelefoniaContext _context;
    public ResponsavelRepository(VallourecTelefoniaContext context)
    {
        this._context = context;
        this._context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public async Task<Responsavel[]> GetAllResponsaveisAsync()
    {
        IQueryable<Responsavel> query = _context.Responsavel;

        return await query.ToArrayAsync();
    }

    public async Task<Responsavel> GetResponsavelByIdAsync(int id)
    {
        IQueryable<Responsavel> query = _context.Responsavel.Where(x => x.id == id);

        return await query.FirstOrDefaultAsync();
    }
}
