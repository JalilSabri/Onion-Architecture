using OnionArch.Application.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Management
{
    public class Semester : TBaseEntity<string>
    {
        public Semester()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Finish Date")]
        public DateTime FinishDate { get; set; }
        public short Capacity { get; set; }
    }
}
