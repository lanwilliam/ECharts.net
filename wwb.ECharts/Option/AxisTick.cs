/**
 * 作者：王文斌
 * 做成日期：2015-10-20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 坐标轴小标记
    /// </summary>
    public class AxisTick
    {
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 小标记显示挑选间隔，默认为'auto'，可选为： 
        /// 'auto'（随axisLabel，自动隐藏显示不下的） | 0（全部显示） | 
        /// {number}（用户指定选择间隔） 
        /// {function}函数回调，传递参数[index，data[index]]，返回true显示，返回false隐藏
        /// </summary>
        public string Interval { set; get; }

        private bool? onGap = null;
        /// <summary>
        /// 小标记是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public bool? OnGap { set { this.onGap = value; } get { return this.onGap; } }

        /// <summary>
        /// 小标记是否显示为在grid内部，默认在外部
        /// </summary>
        public bool? Inside { set; get; }

        
        /// <summary>
        /// 属性length控制线长 默认5
        /// </summary>
        public Number? Length { set; get; }

        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle lineStyle { set; get; }


        public AxisTick()
        {
            
        }
    }
}
