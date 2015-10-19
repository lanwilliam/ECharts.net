/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 缩放文本
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 设置按钮文本
    /// </summary>
    public class ZoomTitle
    {
        string dataZoom = "区域缩放";
        /// <summary>
        /// 区域缩放
        /// </summary>
        public string DataZoom 
        { set { this.dataZoom = value; } get { return this.dataZoom; } }

        string dataZoomReset = "区域缩放后退";
        /// <summary>
        /// 区域缩放后退
        /// </summary>
        public string DataZoomReset 
        { set { this.dataZoomReset = value; } get { return this.dataZoomReset; } }
    }
}
