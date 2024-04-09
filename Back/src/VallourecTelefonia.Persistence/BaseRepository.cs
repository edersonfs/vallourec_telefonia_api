using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VallourecTelefonia.Domain;
using VallourecTelefonia.Repository.Contexts;
using VallourecTelefonia.Repository.Contracts;

namespace VallourecTelefonia.Repository;

public class BaseRepository : IBaseRepository
{
    private readonly VallourecTelefoniaContext _context;
    public BaseRepository(VallourecTelefoniaContext context)
    {
        this._context = context;
    }

    public void Add<T>(T entity) where T: class
    {
        _context.Add(entity);
    }

    public void Update<T>(T entity) where T: class 
    {
        _context.Update(entity);
    }

    public void Delete<T>(T entity) where T: class
    {
        _context.Remove(entity);
    }

    public void DeleteRange<T>(T[] entityArray) where T: class
    {
        _context.RemoveRange(entityArray);
    }       

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }                         
}