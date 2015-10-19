/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 区域填充样式
 * */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwb.ECharts.Enums;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 区域填充样式
    /// </summary>
    public class AreaStyle
    {
        /// <summary>
        /// 各异   颜色  
        /// </summary>
        public Color? Color
        { get; set; }

        /// <summary>
        /// 'default' 	 填充样式，目前仅支持'default'(实填充)
        /// </summary>
        public AreaStyleType? Type
        { get; set; }
    }
}
