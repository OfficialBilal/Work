using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

public partial class PartialDemo
{
    public string GetFullName()
    {
        return  _firstName + " " + _lastName;
    }
}
