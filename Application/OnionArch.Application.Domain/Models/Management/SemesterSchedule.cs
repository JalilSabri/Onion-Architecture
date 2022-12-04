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
    public class SemesterSchedule : TBaseEntity<string>
    {
        public SemesterSchedule()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Display(Name = "Finish Time")]
        public string FinishTime { get; set; }
    }
}
