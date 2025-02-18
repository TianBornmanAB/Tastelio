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
    private readonly IPatronService patronService;
    private readonly IMapper mapper;

    public PatronController(IPatronService patronService, IMapper mapper)
    {
        this.patronService = patronService;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddPatron([FromBody] AddPatronRequest request)
    {
        try
        {
            var dto = mapper.Map<PatronDto>(request);
            
            await patronService.AddAsync(dto);
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
            var entity = await patronService.GetAsync(id);

            var response = mapper.Map<PatronResponse>(entity);
            return Ok(response);
        }
        catch
        {
            return BadRequest("Failed to get...");
        }
    }    
    
    [HttpPut]
    public async Task<IActionResult> UpdatePatron([FromBody] UpdatePatronRequest request)
    {
        try 
        { 
            var dto = mapper.Map<PatronDto>(request);

            await patronService.UpdateAsync(dto);
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
            await patronService.DeleteAsync(id);
            return NoContent();
        }
        catch
        {
            return BadRequest("Failed to delete...");
        }
    }
}
