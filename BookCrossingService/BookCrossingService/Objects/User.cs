using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrossingService.Objects
{
    public abstract class User
    {
        public abstract void UpdateUserInfo(params object[] args);
        public virtual string GetUserInfo()
        {
            return string.Empty;
        }
        public bool OrderBook(bool isForReading, TimeSpan timeToRead)
        {
            return false;
        }

        public bool ReceiveBook(bool fromAgency)
        {
            return false;
        }

        public bool Register(bool withAuth)
        {
            return false;
        }
    }
}
