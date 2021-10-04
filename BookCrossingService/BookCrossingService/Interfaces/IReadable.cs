using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossingService.Interfaces
{
    public interface IReadable
    {
        void Read(DateTime startDate);
        void Read();
    }
}
