using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atena.Delegate.Lesson.Interfaces
{
    internal interface IFinancialServices
    {
        public void Withdraw();
        public void Deposit();
        public void CheckAccount();
    }
}
