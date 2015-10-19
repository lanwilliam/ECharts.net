/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 区域填充样式
    /// </summary>
    public class Normal
    {
        /// <summary>
        /// 图表各异   颜色
        /// </summary>
        public Color? Color
        { get; set; }

        /// <summary>
        /// 边框线宽
        /// </summary>
        public Number? BorderWidth
        { set; get; }

        /// <summary>
        /// 图表各异   线条样式
        /// </summary>
        public LineStyle LineStyle
        { get; set; }

        /// <summary>
        /// 图表各异   区域样式
        /// </summary>
        public AreaStyle AreaStyle
        { get; set; }

        /// <summary>
        /// {show: true, position:'outer'}   标签，饼图默认显示在外部，离饼图距离由labelLine.length决定，地图标签不可指定位置
        /// </summary>
        public Label Label
        { get; set; }

        /// <summary>
        /// {show: true}   饼图标签视觉引导线，默认显示
        /// </summary>
        public LabelLine LabelLine
        { get; set; }
    }
}
