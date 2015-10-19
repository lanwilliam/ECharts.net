/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 图形转换，陆续完善
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 动态类型切换，支持直角系下的折线图、柱状图、堆积、平铺转换,支持图形请自行尝试
    /// 比较麻烦，回头有空再弄
    /// </summary>
    public class MagicType
    {
        /// <summary>
        /// 显示按钮
        /// </summary>
        public bool? Show
        { set; get; }

        /// <summary>
        /// 变换类型，不是默认格式全支持，用的时候自己试一下
        /// line和bar应该没问题
        /// </summary>
        public string[] Type
        { set; get; }

        /// <summary>
        /// 变换图形设置 目前只支持Funnel，陆续添加中
        /// </summary>
        public Option Option
        { set; get; }
        
    }


    /// <summary>
    /// 变换数据对象，需要陆续完善
    /// </summary>
    public class Option
    {
        public Funnel Funnel { set; get; }
    }

    public class Funnel
    {
        public string X
        { set; get; }
        public string Y
        { set; get; }

        public string Width
        {
            set;
            get;
        }

        public Enums.XAlign FunnelAlign
        { set; get; }

        public int Max { set; get; }
    }
}
