using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Services.Models;

namespace TestApp.Services.Profiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(des => des.Address,
                opt => opt.MapFrom(des => $"{des.AddressNo}, {des.Street}, {des.City}"));
            CreateMap<CreateAuthorDto, Author>();
        }
    }
}
