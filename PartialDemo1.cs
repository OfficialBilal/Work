﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

public partial class PartialDemo
{
    private string _firstName;

    private string _lastName;

    public string FirstName
    {
        set { _firstName = value; }
        get { return  _firstName; }
    }

    public string LastName
    {
        set { _lastName = value; }
        get { return _lastName; }
    }
}
