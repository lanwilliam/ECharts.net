using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class Tooltip
    {
        public string trigger = "item";
        public string formatter = "{b}";

        string format = @"
    {
        trigger: '{0}',
        formatter: '{1}'
    }
";
        public string GetTooltipString()
        {
            return Util.Format(format, trigger, formatter);
        }
    }
}
