/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using wwb.ECharts.Enums;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 文字样式
    /// </summary>
    public class TextStyle
    {
        /// <summary>
        /// 颜色
        /// </summary>
        public Color? Color
        { get; set; }

        /// <summary>
        /// 修饰，仅对tooltip.textStyle生效
        /// </summary>
        public string Decoration
        {
            get;
            set;
        }

        /// <summary>
        /// 水平对齐方式，可选为：'left' | 'right' | 'center'
        /// </summary>
        public XAlign? Align
        { get; set; }

        /// <summary>
        /// 垂直对齐方式，可选为：'top' | 'bottom' | 'middle'
        /// </summary>
        public YAlign? Baseline
        { get; set; }

        /// <summary>
        /// 字体系列
        /// </summary>
        public string FontFamily
        { get; set; }

        /// <summary>
        /// 字号 ，单位px
        /// </summary>
        public Number? FontSize
        { get; set; }

        /// <summary>
        /// 样式，可选为：'normal' | 'italic' | 'oblique'
        /// </summary>
        public TextFontStyle? FontStyle
        { get; set; }

        /// <summary>
        /// 粗细，可选为：'normal' | 'bold' | 'bolder' | 'lighter' | 100 | 200 |... | 900
        /// </summary>
        public TextFontWeight? FontWeight
        { get; set; }

    }
}
