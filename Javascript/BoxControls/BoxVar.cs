using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naizari.Javascript
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BoxVar : Attribute
    {
        public BoxVar() { }
        
    }
}
