using AutoMapper;
using System.Linq.Expressions;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Domain.Entities;

namespace Tastelio.Application.Mapping;

public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<PatronDto, Patron>()
            .ForMember(dest => dest.DateCreated, opt => opt.Ignore());
        CreateMap<Patron, PatronDto>();
    }
}
