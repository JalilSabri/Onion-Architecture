using OnionArch.Application.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Management
{
    public class Department : TBaseEntity<string>
    {
        public Department()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string DepartmentTitle { get; set; }
    }
}
