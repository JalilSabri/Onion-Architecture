using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Domain.Interfaces.Base
{
    public interface ISampleService
    {
        string print(int x);
    }

    public class SampleService : ISampleService
    {
        public SampleService()
        {
            int mm = 10;
            mm++;
        }
        public string print(int x)
        {
            x++;
            return x.ToString();
        }
    }
}
