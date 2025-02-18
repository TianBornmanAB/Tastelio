using AutoMapper;
using Tastelio.Api.Requests;
using Tastelio.Api.Response;
using Tastelio.Application.DataTransferObjects;

namespace Tastelio.Api.Mapping;

public class ApiProfile : Profile
{
    public ApiProfile()
    {
        CreateMap<AddPatronRequest, PatronDto>();
        CreateMap<UpdatePatronRequest, PatronDto>();
        CreateMap<PatronDto, PatronResponse>();
    }
}
