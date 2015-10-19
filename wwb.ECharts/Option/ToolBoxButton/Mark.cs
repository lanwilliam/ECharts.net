/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 辅助线设置
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 辅助线标志
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// 是否显示辅助线按钮
        /// </summary>
        public bool? Show
        { set; get; }

        /// <summary>
        /// 可以调整按钮文本，默认辅助线开关，删除辅助线，清空辅助线，如无必要可以无视
        /// </summary>
        public MarkTitle Title
        { set; get; }

        /// <summary>
        /// 控制线条样式
        /// </summary>
        public LineStyle LineStyle
        { set; get; }
    }
}
