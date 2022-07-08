using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atena.Delegate.Lesson.Interfaces
{
    public delegate void InternationalWithdraw(); 
    public interface IInternationalService
    {       
       public void InternationalWithdraw(InternationalWithdraw internationalWithdraw);

    }
    public interface IInternationalBank : IInternationalService   
    {       

    }
}
