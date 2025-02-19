using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tastelio.Api.Requests;
using Tastelio.Api.Response;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Application.Services.Abstractions;

namespace Tastelio.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EstablishmentController : ControllerBase
{
    private readonly IEstablishmentService service;
    private readonly IMapper mapper;

    public EstablishmentController(IEstablishmentService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddEstablishment([FromBody] AddEstablishmentRequest request)
    {
        try
        {
            var dto = mapper.Map<EstablishmentDto>(request);
            
            await service.AddAsync(dto);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to add...");
        }
    }

    [HttpGet]
    public async Task<ActionResult<EstablishmentResponse>> GetEstablishment([FromQuery] Guid id)
    {
        try 
        { 
            var dto = await service.GetAsync(id);

            var response = mapper.Map<EstablishmentResponse>(dto);
            return Ok(response);
        }
        catch
        {
            return BadRequest("Failed to get...");
        }
    }

    [HttpGet("paged")]
    public async Task<ActionResult<PagedResponse<EstablishmentResponse>>> GetEstablishments([FromQuery] PagedRequest request)
    {
        try
        {
            var dto = mapper.Map<PagedDto<EstablishmentDto>>(request);

            dto = await service.GetAsync(dto);

            var response = mapper.Map<PagedResponse<EstablishmentResponse>>(dto);
            return Ok(response);
        }
        catch
        {
            return BadRequest("Failed to get paged...");
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateEstablishment([FromBody] UpdateEstablishmentRequest request)
    {
        try 
        { 
            var dto = mapper.Map<EstablishmentDto>(request);

            await service.UpdateAsync(dto);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to update...");
        }
    }    
    
    [HttpDelete]
    public async Task<IActionResult> DeleteEstablishment([FromQuery] Guid id)
    {
        try 
        { 
            await service.DeleteAsync(id);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to delete...");
        }
    }
}
