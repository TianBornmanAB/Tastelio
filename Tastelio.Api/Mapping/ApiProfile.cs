using AutoMapper;
using Tastelio.Api.Requests;
using Tastelio.Application.DataTransferObjects;

namespace Tastelio.Api.Mapping;

public class ApiProfile : Profile
{
    public ApiProfile()
    {
        CreateMap<PatronRequest, PatronDto>();
    }
}
