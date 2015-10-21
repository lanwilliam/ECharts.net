using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Helpers
{
    public class StringFormatter
    {
        public bool isFunction { set; get; }
        public string Formatter { set; get; }

        public StringFormatter() { }

        public StringFormatter(string formatter)
        {
            this.Formatter = formatter;
        }
    }
}
