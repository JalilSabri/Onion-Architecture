using OnionArch.Application.Domain.Interfaces.Base;
using OnionArch.Application.Domain.Models;
using OnionArch.Application.Domain.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Interfaces.Management
{
    public interface ISampleRepository : IBaseRepository<Teacher>
    {
        // Repository interface for each entity doesn't need in this architecture
    }
}
