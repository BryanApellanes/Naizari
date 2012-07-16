using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naizari.Data
{
    public class IdColumnNotDefinedException: Exception
    {
        public IdColumnNotDefinedException(string tableName)
            : base(string.Format("Id column is not defined on the table {0}", tableName))
        { }
        
    }
}
