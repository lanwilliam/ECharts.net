/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Enums;
using System.Drawing;
using wwb.ECharts.Option;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 图例，每个图表最多仅有一个图例。
    /// </summary>
    public class Legend
    {
        
        /// <summary>
        /// 'horizontal' 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical' 
        /// </summary>
        public OrientType? Orient
        {
            get; set;
        }

        /// <summary>
        /// 'center' 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public XAlign? X
        { get; set; }

        /// <summary>
        /// 'top' 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public YAlign? Y
        { get; set; }

        /// <summary>
        /// 'rgba(0,0,0,0)' 图例背景颜色，默认透明
        /// </summary>
        public Color? BackgroundColor
        { get; set; }

        /// <summary>
        /// '#ccc' 图例边框颜色
        /// </summary>
        public Color? BorderColor
        { get; set; }

        /// <summary>
        /// 0 图例边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public Number? BorderWidth
        { get; set; }

        /// <summary>
        /// 5 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css
        /// </summary>
        public int?[] Padding
        { get; set; }

        /// <summary>
        /// 10 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔
        /// </summary>
        public Number? ItemGap
        { get; set; }

        /// <summary>
        /// {color: '#333'} 默认只设定了图例文字颜色
        /// </summary>
        public TextStyle TextStyle
        { get; set; }

        /// <summary>
        /// 配置默认选中状态，可配合LEGEND.SELECTED事件做动态数据载入
        /// </summary>
        public object Selected
        { get; set; }

        /// <summary>
        /// 图例内容数组，数组项为{string}，每一项代表一个系列的name。
        /// </summary>
        public string[] Data
        { get; set; }
        
    }
}
