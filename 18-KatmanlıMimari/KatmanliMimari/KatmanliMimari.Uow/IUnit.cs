using KatmanliMimari.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public interface IUnit
    {
        IPersonnalRep _personelRep { get; }
        void Commit();
    }
}
