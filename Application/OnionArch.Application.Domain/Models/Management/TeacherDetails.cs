using OnionArch.Application.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Management
{
    public class TeacherDetails : TBaseEntity<string>
    {
        public TeacherDetails()
        {
            Id = Guid.NewGuid().ToString();
        }
        public byte? Gender { get; set; }
        public bool? MaritalStatus { get; set; }
        public short ChildernNumber { get; set; }
        public byte Age { get; set; }
    }
}
