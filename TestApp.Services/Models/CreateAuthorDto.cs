using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services.Models
{
    public class CreateAuthorDto
    {
        public string? FullName { get; set; }
        public string? AddressNo { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
    }
}
