using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Klase
{
    internal class GrupiraniMiliunasi
    {
        public string Banka { get; set; }
        public IEnumerable<string> Miliunasi { get; set; }
    }
}
