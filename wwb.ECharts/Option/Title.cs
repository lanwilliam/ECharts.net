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

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标题，每个图表最多仅有一个标题控件，每个标题控件可设主副标题。
    /// </summary>
    public class Title
    {

        /// <summary>
        /// 主标题文本
        /// </summary>
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// 副标题文本
        /// </summary>
        public string Subtext
        {
            get;
            set;
        }

        /// <summary>
        /// 水平安放位置，默认为左侧，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public XAlign? X
        {
            get;
            set;
        }

        /// <summary>
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public YAlign? Y
        {
            get;
            set;
        }

        /// <summary>
        /// 水平对齐方式，默认根据x设置自动调整，可选为： left' | 'right' | 'center
        /// </summary>
        public XAlign? TextAlign
        {
            get;
            set;
        }

        /// <summary>
        /// 标题背景颜色，默认透明
        /// </summary>
        public Color? BackgroundColor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 标题边框颜色
        /// </summary>
        public Color? BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// 标题边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public Number? BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css
        /// </summary>
        public int?[] Padding
        {
            get;
            set;
        }

        /// <summary>
        /// 主副标题纵向间隔，单位px，默认为10
        /// </summary>
        public Number? ItemGap
        {
            get;
            set;
        }

        /// <summary>
        /// 主标题文本样式
        /// </summary>
        public TextStyle TextStyle
        {
            get;
            set;
        }

        /// <summary>
        /// 副标题文本样式
        /// </summary>
        public TextStyle SubtextStyle
        { get; set; }
    }
}
