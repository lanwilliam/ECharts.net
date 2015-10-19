/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwb.ECharts.Enums;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Label
    {
        /// <summary>
        /// true   标签显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public bool? Show
        { get; set; }

        /// <summary>
        /// 'outer'	   标签显示位置，可选为：'outer'（外部） | 'inner'（内部），地图标签不可指定位置
        /// </summary>
        public LabelPositionType Position
        { get; set; }

        /// <summary>
        /// null   标签文本格式器，仅饼图支持，同Tooltip.formatter，不支持回调
        /// </summary>
        public string Formatter
        { get; set; }

        /// <summary>
        /// null   标签的文本样式
        /// </summary>
        public TextStyle TextStyle
        { get; set; }
    }
}
