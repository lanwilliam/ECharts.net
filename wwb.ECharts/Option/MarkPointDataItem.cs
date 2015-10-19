/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 通用的标点类，MarkLine里面共享
 * Type等属性在部分图标中使用，根据api对应选择
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标注数据点对象
    /// </summary>
    public class MarkPointDataItem
    {

        public MarkPointDataItem() { }

        public MarkPointDataItem(string name) { this.Name = name; }

        public MarkPointDataItem(string name,Number? x,Number? y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public MarkPointDataItem(string name, Number? x, Number? y,Number? value)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Value = value;
        }

        /// <summary>
        /// 点名称
        /// </summary>
        public string Name
        { get; set; }

        /// <summary>
        /// x坐标
        /// </summary>
        public Number? X
        { set; get; }

        /// <summary>
        /// y坐标
        /// </summary>
        public Number? Y
        { set; get; }

        /// <summary>
        /// 数值
        /// </summary>
        public Number? Value
        { set; get; }

        /// <summary>
        /// 在某些图表下使用，自行对照API
        /// max,min,average
        /// </summary>
        public string Type
        { set; get; }
    }
}
