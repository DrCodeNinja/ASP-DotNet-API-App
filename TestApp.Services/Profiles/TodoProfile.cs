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
    public class TodoProfile:Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo,TodoDto>();
        }
    }
}
