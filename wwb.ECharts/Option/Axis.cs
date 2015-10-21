/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;
using wwb.ECharts.Enums;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 坐标轴有两种类型，类目型和数值型。  类目型：需要指定类目列表，坐标轴内有且仅有这些指定类目坐标  数值型：需要指定数值区间，坐标轴内包含数值区间内容全部坐标
    /// </summary>
    public class Axis
    {
        /// <summary>
        /// 通用  坐标轴类型，横轴默认为类目型'category'，纵轴默认为数值型'value'
        /// </summary>
        public AxisType? Type
        { get; set; }

        /// <summary>
        /// 通用  坐标轴类型，横轴默认为类目型'bottom'，纵轴默认为数值型'left'，可选为：'bottom' | 'top' | 'left' | 'right'
        /// </summary>
        public PositionType? Position
        { get; set; }

        /// <summary>
        /// ''   坐标轴名称，默认为空
        /// </summary>
        public string Name
        { get; set; }

        /// <summary>
        /// 'end'  坐标轴名称位置，默认为'end'，可选为：'start' | 'end'
        /// </summary>
        public NameLocationType? NameLocation
        { get; set; }

        /// <summary>
        /// 类目起始和结束两端空白策略，见下图，默认为true留空，false则顶头
        /// </summary>
        public BoundaryGapType BoundaryGap
        { get; set; }

        /// <summary>
        /// {Array} boundaryGap  
        /// </summary>
        public string ThisIsError
        { get; set; }

        /// <summary>
        /// null   指定的最小值，eg: 0，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[0]
        /// </summary>
        public Number? Min
        { get; set; }

        /// <summary>
        /// null   指定的最大值，eg: 100，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[1]
        /// </summary>
        public Number? Max
        { get; set; }

        /// <summary>
        /// false 脱离0值比例，放大聚焦到最终_min，_max区间
        /// </summary>
        public bool? Scale
        { get; set; }

        /// <summary>
        /// 0   小数精度，默认为0，无小数点
        /// </summary>
        public Number? Precision
        { get; set; }

        /// <summary>
        /// 100  整数精度，默认为100，个位和百位为0
        /// </summary>
        public Number? Power
        { get; set; }

        /// <summary>
        /// 5   分割段数，默认为5
        /// </summary>
        public Number? SplitNumber
        { get; set; }

        /// <summary>
        /// 坐标轴小标记
        /// </summary>
        public AxisTick axisTick { set; get; }

        /// <summary>
        /// 分隔线
        /// </summary>
        public SplitLine splitLine { set; get; }

        /// <summary>
        /// 类目型坐标轴文本标签数组，指定label内容。 数组项通常为文本
        /// </summary>
        public string[] Data
        { get; set; }
    }
}
