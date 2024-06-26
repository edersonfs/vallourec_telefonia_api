using System.Threading.Tasks;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.Repository.Contracts;

public interface IBaseRepository
{
    // GERAL
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(T[] entity) where T : class;
    Task<bool> SaveChangesAsync();
}