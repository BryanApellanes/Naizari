/*
	Copyright © Bryan Apellanes 2015  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naizari.Javascript.JsonControls
{
    public class JsonWindowScrollEventSource: JsonEventSource
    {
        public JsonWindowScrollEventSource()
            : base()
        {
            this.ExecutionType = JavascriptExecutionTypes.OnWindowScroll;
        }
    }
}
