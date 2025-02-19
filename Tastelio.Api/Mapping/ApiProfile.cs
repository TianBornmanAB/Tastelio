using AutoMapper;
using Tastelio.Api.Requests;
using Tastelio.Api.Response;
using Tastelio.Application.DataTransferObjects;

namespace Tastelio.Api.Mapping;

public class ApiProfile : Profile
{
    public ApiProfile()
    {
        // Establishment
        CreateMap<AddEstablishmentRequest, EstablishmentDto>();
        CreateMap<UpdateEstablishmentRequest, EstablishmentDto>();
        CreateMap<PagedRequest, PagedDto<EstablishmentDto>>();
        CreateMap<EstablishmentDto, EstablishmentResponse>();
        CreateMap<PagedDto<EstablishmentDto>, PagedResponse<EstablishmentResponse>>();

        // Patron
        CreateMap<AddPatronRequest, PatronDto>();
        CreateMap<UpdatePatronRequest, PatronDto>();
        CreateMap<PagedRequest, PagedDto<PatronDto>>();
        CreateMap<PatronDto, PatronResponse>();
        CreateMap<PagedDto<PatronDto>, PagedResponse<PatronResponse>>();
    }
}
