using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tastelio.Api.Requests;
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
    public async Task<IActionResult> AddPatron(PatronRequest request)
    {
        var dto = mapper.Map<PatronDto>(request);

        await patronService.AddAsync(dto);
        return Ok();
    }
}
