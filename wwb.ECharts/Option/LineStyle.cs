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
using wwb.ECharts.Enums;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 线条（线段）样式
    /// </summary>
    public class LineStyle
    {
        /// <summary>
        /// 各异  颜色
        /// </summary>
        public Color? Color
        { get; set; }

        /// <summary>
        /// 'solid'	 线条样式，可选为：'solid' | 'dotted' | 'dashed'
        /// </summary>
        public LineStyleType? Type
        { get; set; }

        /// <summary>
        /// 各异   线宽 
        /// </summary>
        public Number? Width
        { get; set; }

        /// <summary>
        /// rgba(0,0,0,0)   折线主线(IE8+)有效，阴影色彩，支持rgba
        /// </summary>
        public Color? ShadowColor
        { get; set; }

        /// <summary>
        /// 5   折线主线(IE8+)有效，阴影模糊度，大于0有效
        /// </summary>
        public Number? ShadowBlur
        { get; set; }

        /// <summary>
        /// 3   折线主线(IE8+)有效，阴影横向偏移，正值往右，负值往左
        /// </summary>
        public Number? ShadowOffsetX
        { get; set; }

        /// <summary>
        /// 3   折线主线(IE8+)有效，阴影纵向偏移，正值往下，负值往上
        /// </summary>
        public Number? ShadowOffsetY
        { get; set; }

    }
}
