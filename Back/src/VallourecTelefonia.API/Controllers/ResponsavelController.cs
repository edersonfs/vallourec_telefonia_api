using Microsoft.AspNetCore.Mvc;
using VallourecTelefonia.Application.Contracts;
using VallourecTelefonia.Domain;

namespace VallourecTelefonia.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResponsavelController : ControllerBase
{
    private readonly IResponsavelService _responsavelService;

    public ResponsavelController(IResponsavelService responsavelService)
    {
        this._responsavelService = responsavelService;
    }

    [HttpGet(Name = "GetResponsavel")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var responsaveis = await _responsavelService.GetAllResponsaveisAsync();

            if (responsaveis == null) return NotFound("Nenhnum responsavel encontrado");

            return Ok(responsaveis);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar responsaveis. Erro {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Responsavel>> GetById(int id) 
    {
        try
        {
            var responsavel = await _responsavelService.GetResponsavelByIdAsync(id);

            if (responsavel == null) return NotFound("Nenhnum responsavel encontrado");

            return Ok(responsavel);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar responsaveis. Erro {ex.Message}");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post(Responsavel model)
    {
        try
        {
            var responsavel = await _responsavelService.AddResponsavel(model);

            if (responsavel == null) return BadRequest("Erro ao tentar adicionar Responsavel");

            return Ok(responsavel);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar responsaveis. Erro {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Responsavel model)
    {
        try
        {
            var responsavel = await _responsavelService.UpdateResponsavel(id, model);

            if (responsavel == null) return BadRequest("Erro ao tentar adicionar Responsavel");

            return Ok(responsavel);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar responsaveis. Erro {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if (await _responsavelService.DeleteResponsavel(id))
            {
                return Ok("Deletado");
            }
            else
            {
                return BadRequest("Resposavel nao deleteado");
            }
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar responsavel. Erro {ex.Message}");
        }
    }
}
