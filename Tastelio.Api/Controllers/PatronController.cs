using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tastelio.Api.Requests;
using Tastelio.Api.Response;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Application.Services.Abstractions;

namespace Tastelio.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PatronController : ControllerBase
{
    private readonly IPatronService service;
    private readonly IMapper mapper;

    public PatronController(IPatronService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddPatron([FromBody] AddPatronRequest request)
    {
        try
        {
            var dto = mapper.Map<PatronDto>(request);
            
            await service.AddAsync(dto);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to add...");
        }
    }

    [HttpGet]
    public async Task<ActionResult<PatronResponse>> GetPatron([FromQuery] Guid id)
    {
        try 
        { 
            var dto = await service.GetAsync(id);

            var response = mapper.Map<PatronResponse>(dto);
            return Ok(response);
        }
        catch
        {
            return BadRequest("Failed to get...");
        }
    }

    [HttpGet("paged")]
    public async Task<ActionResult<PagedResponse<PatronResponse>>> GetPatrons([FromQuery] PagedRequest request)
    {
        try
        {
            var dto = mapper.Map<PagedDto<PatronDto>>(request);

            dto = await service.GetAsync(dto);

            var response = mapper.Map<PagedResponse<PatronResponse>>(dto);
            return Ok(response);
        }
        catch
        {
            return BadRequest("Failed to get paged...");
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePatron([FromBody] UpdatePatronRequest request)
    {
        try 
        { 
            var dto = mapper.Map<PatronDto>(request);

            await service.UpdateAsync(dto);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to update...");
        }
    }    
    
    [HttpDelete]
    public async Task<IActionResult> DeletePatron([FromQuery] Guid id)
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
