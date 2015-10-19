/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 图形样式，可设置图表内图形的默认样式和强调样式（悬浮时样式）
    /// </summary>
    public class ItemStyle
    {
        /// <summary>
        /// 默认样式
        /// </summary>
        public Normal Normal
        { get; set; }

        /// <summary>
        /// 强调样式
        /// </summary>
        public Emphasis Emphasis
        { get; set; }
    }
}
