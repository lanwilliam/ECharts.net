/**
 * 作者：王文斌
 * 做成日期：2015-10-20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 分隔线
    /// </summary>
    public class SplitLine
    {
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Show { set; get; }

        /// <summary>
        /// 分隔线是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public bool? onGap { set; get; }

        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle lineStyle { set; get; }

        public SplitLine()
        {
            this.Show = true;
            this.onGap = null;
            
        }
    }
}
