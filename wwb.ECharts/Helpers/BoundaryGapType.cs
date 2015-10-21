using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Helpers
{
    /// <summary>
    /// 坐标轴两端空白策略 请自行处理''号问题
    /// </summary>
    public class BoundaryGapType
    {
        public string Value { set; get; }

        public BoundaryGapType() { }
        public BoundaryGapType(string value)
        { this.Value = value; }
    }
}
