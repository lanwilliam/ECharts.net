/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 工具箱缩放按钮
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// dataZoom，框选区域缩放，自动与存在的dataZoom控件同步
    /// </summary>
    public class DataZoom
    {
        /// <summary>
        /// 显示缩放按钮
        /// </summary>
        public bool? Show
        { set; get; }

        /// <summary>
        /// 可以调节缩放按钮文本，如无必要可以无视
        /// </summary>
        public ZoomTitle Title
        { set; get; }
    }
}
