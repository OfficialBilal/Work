using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

class PartialClass
{
	public static void Main()
	{
        PartialDemo p = new PartialDemo();
        p.FirstName = "Muhammad";
        p.LastName = "Ali";
        p.GetFullName();

    }
}
