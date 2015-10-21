/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Enums;
using wwb.ECharts.Helpers;
using System.Drawing;
using wwb.ECharts.Option.ToolBoxButton;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 工具箱，每个图表最多仅有一个工具箱。
    /// </summary>
    public class ToolBox
    {
        /// <summary>
        /// false 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public bool? Show
        { get; set; }

        /// <summary>
        /// 'horizontal' 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public OrientType? Orient
        { get; set; }

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
        /// 'rgba(0,0,0,0)' 工具箱背景颜色，默认透明
        /// </summary>
        public Color? BackgroundColor
        { get; set; }

        /// <summary>
        /// '#ccc' 工具箱边框颜色
        /// </summary>
        public Color? BorderColor
        { get; set; }

        /// <summary>
        /// 0 工具箱边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public Number? BorderWidth
        { get; set; }

        /// <summary>
        /// 5 工具箱内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css
        /// </summary>
        public Number? Padding
        { get; set; }

        /// <summary>
        /// 10 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔
        /// </summary>
        public Number? ItemGap
        { get; set; }

        /// <summary>
        /// 16 工具箱icon大小，单位（px）
        /// </summary>
        public Number? ItemSize
        { get; set; }

        /// <summary>
        /// ['#1e90ff','#22bb22','#4b0082','#d2691e'] 工具箱icon颜色序列，循环使用
        /// </summary>
        public Color?[] Color
        { get; set; }

        private Feature feature;
        /// <summary>
        /// 启用工具箱按钮设置
        /// </summary>
        public Feature Feature
        { 
            set { this.feature = value; }
            get
            {
                if (this.feature == null)
                    this.feature = new Feature();
                return this.feature;
            }
        }
    }
}
