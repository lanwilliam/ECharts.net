/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标签线条
    /// </summary>
    public class LabelLine
    {
        /// <summary>
        /// true   饼图标签视觉引导线显示策略，可选为：true（显示） | false（隐藏） 
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// 40   线长 ，从外圆边缘起计算，可为负值
        /// </summary>
        public Number? Length
        { get; set; }

        /// <summary>
        /// 各异   线条样式
        /// </summary>
        public LineStyle LineStyle
        { get; set; }
    }
}
