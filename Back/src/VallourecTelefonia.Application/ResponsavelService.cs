using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VallourecTelefonia.Application.Contracts;
using VallourecTelefonia.Domain;
using VallourecTelefonia.Repository.Contracts;

namespace VallourecTelefonia.Application;

public class ResponsavelService : IResponsavelService
{
    private readonly IBaseRepository _baseRepository;
    private readonly IResponsavelRepository _responsavelRepository;

    public ResponsavelService(IBaseRepository baseRepository, IResponsavelRepository responsavelRepository)
    {
        this._baseRepository = baseRepository;
        this._responsavelRepository = responsavelRepository;
    }
    public async Task<Responsavel> AddResponsavel(Responsavel model)
    {
        try
        {
            _baseRepository.Add<Responsavel>(model);
            if (await _baseRepository.SaveChangesAsync())
            {
                return await _responsavelRepository.GetResponsavelByIdAsync(model.id);
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public async Task<Responsavel> UpdateResponsavel(int id, Responsavel model)
    {
        try
        {
            var responsavel = await _responsavelRepository.GetResponsavelByIdAsync(id);

            if (responsavel == null) return null;

            model.id = responsavel.id;

            _baseRepository.Update(model);

            if (await _baseRepository.SaveChangesAsync())
            {
                return await _responsavelRepository.GetResponsavelByIdAsync(model.id);
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<bool> DeleteResponsavel(int id)
    {
        try
        {
            var responsavel = await _responsavelRepository.GetResponsavelByIdAsync(id);

            if (responsavel == null) throw new Exception("Responsavel para deltete nao encontrado");

            _baseRepository.Delete<Responsavel>(responsavel);

            return await _baseRepository.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Responsavel[]> GetAllResponsaveisAsync()
    {
        try
        {
            var responsaveis = await _responsavelRepository.GetAllResponsaveisAsync();

            if (responsaveis == null) return null;

            return responsaveis;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Responsavel> GetResponsavelByIdAsync(int id)
    {
        try
        {
            var responsaveis = await _responsavelRepository.GetResponsavelByIdAsync(id);

            if (responsaveis == null) return null;

            return responsaveis;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
