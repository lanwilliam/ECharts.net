/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 坐标轴线，默认显示且带如下样式：
    /// </summary>
    public class MapLocation
    {
        /// <summary>
        /// 地图 X
        /// </summary>
        public XAxis X
        { get; set; }

        /// <summary>
        /// 地图 Y
        /// </summary>
        public YAxis Y
        { get; set; }

        /// <summary>
        /// 地图 width
        /// </summary>
        public Number? Width
        { get; set; }

        /// <summary>
        /// 地图 height
        /// </summary>
        public Number? Height
        { get; set; }
    }
}
