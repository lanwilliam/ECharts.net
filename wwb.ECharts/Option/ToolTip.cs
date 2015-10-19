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
using System.Drawing;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 提示框,鼠标悬浮交互时的信息提示。
    /// </summary>
    public class ToolTip
    {
        /// <summary>
        /// 'item' 触发类型，默认数据触发 可选为：'item' | 'axis'
        /// </summary>
        public TriggerType? Trigger
        { get; set; }

        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public bool? Show
        { get; set; }

        /// <summary>
        /// null 内容格式器：{string}（Template） | {Function}，支持异步回调见表格下方
        /// </summary>
        public string Formatter
        { get; set; }

        /// <summary>
        /// '{a} < br/>{b} : {c}' 拖拽重计算独有，数据孤岛内容格式器：{string}（Template） | {Function}
        /// </summary>
        public string IslandFormatter
        { get; set; }

        /// <summary>
        /// 30 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        /// </summary>
        public Number? ShowDelay
        { get; set; }

        /// <summary>
        /// 100 隐藏延迟，单位ms
        /// </summary>
        public Number? HideDelay
        { get; set; }

        /// <summary>
        /// 1 动画变换时长，单位s
        /// </summary>
        public Number? TransitionDuration
        { get; set; }

        /// <summary>
        /// 'rgba(0,0,0,0.7)'  提示背景颜色，默认为透明度为0.7的黑色
        /// </summary>
        public Color? BackgroundColor
        { get; set; }

        /// <summary>
        /// '#333'  提示边框颜色
        /// </summary>
        public Color? BorderColor
        { get; set; }

        /// <summary>
        /// 4 提示边框圆角，单位px，默认为4
        /// </summary>
        public Number? BorderRadius
        { get; set; }

        /// <summary>
        /// 0 提示边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public Number? BorderWidth
        { get; set; }

        /// <summary>
        /// 5  提示内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        public int?[] Padding
        { get; set; }

        /// <summary>
        /// 坐标轴指示器
        /// </summary>
        public object AxisPointer
        { get; set; }

        /// <summary>
        /// { color:'#fff' } 文本样式，默认为白色字体
        /// </summary>
        public TextStyle TextStyle
        { get; set; }

    }
}
