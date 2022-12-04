using OnionArch.Application.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Management
{
    public class Teacher : TBaseEntity<string>
    {
        public Teacher()
        {
            Id = Guid.NewGuid().ToString();
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
