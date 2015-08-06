﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAPAutomation.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TableBindingAttribute : Attribute
    {
        public string TableName { get; set; }

        public TableBindingAttribute(string TableName, string IdColumnName)
        {
            this.TableName = TableName;
            this.IdColumnName = IdColumnName;
        }

        public string IdColumnName { get; set; }
    }
}
