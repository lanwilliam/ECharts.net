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

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标注线条内容
    /// series.markLine
    /// 系列中的数据标线内容
    /// </summary>
    public class MarkLine
    {
        /// <summary>
        /// 定义线条两端点类型，依次顺序 起点,终点['circle', 'arrow']
        /// </summary>
        public SymbolType[] Symbol
        { set; get; }

        /// <summary>
        /// 标线起始和结束的symbol大小，半宽（半径）参数，如果都一样，可以直接传一个
        /// </summary>
        public Number[] SymbolSize
        { set; get; }

        /// <summary>
        /// 标线起始和结束的symbol旋转控制，同series中的symbolRotate
        /// </summary>
        public Number[] SymbolRotate
        { set; get; }

        /// <summary>
        /// 是否启用大规模标线模式，默认关闭。 
        /// 大规模标线模式下会优化标线绘制，同个系列的的所有标线都会使用同一种样式，并且忽略标线两端 symbol 的绘制。
        /// </summary>
        public bool? Large
        { set; get; }

        /// <summary>
        /// 平滑曲线显示，smooth为true时lineStyle不支持虚线
        /// </summary>
        public bool? Smooth
        { set; get; }

        /// <summary>
        /// 平滑曲线弧度，smooth为true时有效，指定平滑曲线弧度 默认0.2
        /// </summary>
        public Number? Smoothness
        { set; get; }

        /// <summary>
        /// 标线图形炫光特效: 
        /// </summary>
        public Effect Effect
        {
            set;
            get;
        }

        /// <summary>
        /// 标线图形样式属性，同series中的itemStyle
        /// </summary>
        public ItemStyle ItemStyle
        { set; get; }

        /// <summary>
        /// 标线图形数据
        /// Bar,Line等图形可用MarkPointDataItem[] 直接通过Type设置平均值等信息
        /// Map等地图需要用MarkPointDataItem[,]
        /// 具体请根据实际情况使用
        /// </summary>
        public object Data
        { set; get; }
    }
}
