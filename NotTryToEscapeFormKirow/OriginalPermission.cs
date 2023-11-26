using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    internal class OriginalPermission
    {
        public String Name { get; protected set; }
        public String LastName { get; protected set; }
        public int Id { get; protected set; }
        //
        public bool stamp { get; protected set; }
        public String NameIana { get; protected set; }
        public String LastNameIana { get; protected set; }

        public OriginalPermission(Pasport p)
        {
            Name = p.Name;
            LastName = p.LastName;
            Id = p.Id;
            stamp = true;
            LastNameIana = "Цист";
            NameIana = "Яна";
        }
    }
}
