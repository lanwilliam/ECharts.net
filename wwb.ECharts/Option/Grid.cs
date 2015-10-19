/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;
using System.Drawing;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 直角坐标系内绘图网格
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// 80  直角坐标系内绘图网格起始横坐标，数值单位px
        /// </summary>
        public Number? X
        { get; set; }

        /// <summary>
        /// 60  直角坐标系内绘图网格起始纵坐标，数值单位px
        /// </summary>
        public Number? Y
        { get; set; }

        /// <summary>
        /// 自适应	 直角坐标系内绘图网格（不含坐标轴）宽度，默认为总宽度 - 2 * x，数值单位px
        /// </summary>
        public Number? Width
        { get; set; }

        /// <summary>
        /// 自适应   直角坐标系内绘图网格（不含坐标轴）高度，默认为总宽度 - 2 * y，数值单位px
        /// </summary>
        public Number? Height
        { get; set; }

        /// <summary>
        /// '#fff'  背景颜色。
        /// </summary>
        public Color? BackgroundColor
        { get; set; }

        /// <summary>
        /// 1  边框线宽
        /// </summary>
        public Number? BorderWidth
        { get; set; }

        /// <summary>
        /// '#ccc'  边框颜色。
        /// </summary>
        public Color? BorderColor
        { get; set; }
    }
}
