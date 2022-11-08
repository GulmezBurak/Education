using KatmanliMimari.Core;
using KatmanliMimari.Dl;
using KatmanliMimari.Ent;
using KatmanliMimari.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Rep.Concrete
{
    public class PersonnalRep<T> : BaseRepository<Personnal>, IPersonnalRep where T : class
    {
        public PersonnalRep(MyContext db) : base(db)
        {
           
        }
    }
}
