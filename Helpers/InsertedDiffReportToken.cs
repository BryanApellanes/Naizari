using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Naizari.Helpers
{
    [Serializable]
    [XmlInclude(typeof(DiffReportToken))]
    public class InsertedDiffReportToken: DiffReportToken
    {
        public override DiffType Type
        {
            get
            {
                return DiffType.Inserted;
            }
        }
    }
}
