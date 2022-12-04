using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Models.Base
{
    public class TBaseEntity<TIdType>
    {
        [Key]
        public TIdType Id { get; set; }
    }
}
