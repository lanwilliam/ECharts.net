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
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标注点对象
    /// series.markPoint 系列中的数据标注内容
    /// </summary>
    public class MarkPoint
    {
        /// <summary>
        /// 标注类型 可设多种形状
        /// </summary>
        public SymbolType? Symbol
        { get; set; }

        /// <summary>
        /// 标志图形大小，可计算特性启用情况建议增大以提高交互体验。
        /// </summary>
        public Number? SymbolSize
        { get; set; }

        /// <summary>
        /// null     标志图形旋转角度[-180,180]
        /// </summary>
        public Number? SymbolRotate
        { get; set; }

        /// <summary>
        /// 是否启动大规模标注模式
        /// </summary>
        public bool? Large
        { get; set; }

        /// <summary>
        /// 标注图形炫光特效
        /// </summary>
        public Effect Effect
        { get; set; }

        /// <summary>
        /// 标注图形样式属性，同series中的itemStyle
        /// </summary>
        public ItemStyle ItemStyle
        { get; set; }

        /// <summary>
        /// 标注图形数据
        /// </summary>
        public MarkPointDataItem[] Data
        {
            get;
            set;
        }


    }
}
