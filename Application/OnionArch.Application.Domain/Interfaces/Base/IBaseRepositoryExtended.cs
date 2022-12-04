using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Interfaces.Base
{
    public interface IBaseRepositoryExtended
    {
        public void Commit();

        public Task<int> CommitAsync();
    }
}
