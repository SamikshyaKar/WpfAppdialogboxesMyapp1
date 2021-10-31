using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppdialogboxesMyapp1
{
   public class Name
    {

        public Name(string firstname, string lastname)
        {

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
