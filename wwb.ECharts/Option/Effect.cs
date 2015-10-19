/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using wwb.ECharts.Enums;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 标注图形炫光特效
    /// show 是否开启，默认关闭 
    /// type 特效类型，默认为'scale'（放大），可选还有'bounce'（跳动） 
    /// loop 循环动画，默认开启, 
    /// period 运动周期，无单位，值越大越慢，默认为15 
    /// scaleSize 放大倍数，以markPoint symbolSize为基准，type为scale时有效 
    /// bounceDistance 跳动距离，单位为px，type为bounce时有效 
    /// color 炫光颜色，默认跟随markPoint itemStyle定义颜色, 
    /// shadowColor 光影颜色，默认跟随color 
    /// shadowBlur 光影模糊度，默认为0 
    /// </summary>
    public class Effect
    {
        /// <summary>
        /// show 是否开启
        /// </summary>
        public bool? Show
        { get; set; }

        /// <summary>
        /// 炫光特效类型
        /// </summary>
        public EffectType? Type
        { get; set; }

        /// <summary>
        /// loop 循环动画
        /// </summary>
        public bool? Loop
        { get; set; }

        /// <summary>
        /// period 运动周期，无单位，值越大越慢，默认为15 
        /// </summary>
        public Number? Period
        { get; set; }

        /// <summary>
        /// scaleSize 放大倍数，以markPoint symbolSize为基准，type为scale时有效 
        /// </summary>
        public Number? ScaleSize
        { get; set; }

        /// <summary>
        /// bounceDistance 跳动距离，单位为px，type为bounce时有效 
        /// </summary>
        public Number? BounceDistance
        { get; set; }

        /// <summary>
        /// color 炫光颜色，默认跟随markPoint itemStyle定义颜色, 
        /// </summary>
        public Color Color
        { get; set; }

        /// <summary>
        /// shadowColor 光影颜色，默认跟随color 
        /// </summary>
        public Color ShadowColor
        { get; set; }

        /// <summary>
        /// shadowBlur 光影模糊度，默认为0 
        /// </summary>
        public Number? shadowBlur
        { get; set; }

    }
}
