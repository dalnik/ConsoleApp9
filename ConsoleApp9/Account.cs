using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaseEnum
{
    class Account
    {
        string name;
        string type;

        public Account()
        {
            name = "Andrey Tishchenko";
            type = "Super User";
        }

        public override string ToString()
        {
            return $"{name} {type}";
        }
    }
}
