using OnionArch.Application.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Management
{
    public class Course : TBaseEntity<string>
    {
        public Course()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string CourseTitle { get; set; }
    }
}
