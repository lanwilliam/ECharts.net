using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    /// <summary>
    /// 炫光特效类
    /// </summary>
    public class Effect
    {
        public Effect() { }

        /// <summary>
        /// 创建效果对象
        /// </summary>
        /// <param name="show">是否开启</param>
        /// <param name="loop">循环动画</param>
        /// <param name="period">运动周期，无单位，值越大越慢，默认为15 </param>
        /// <param name="scaleSize">放大倍数，以markLine lineWidth为基准 默认2</param>
        /// <param name="color">炫光颜色，默认跟随markLine itemStyle定义颜色</param>
        /// <param name="shadowColor">光影颜色，默认跟所color</param>
        public Effect(bool show,bool loop,int period,int scaleSize,string color,string shadowColor)
        {
            this.show = show;
            this.loop = loop;
            this.period = period;
            this.scaleSize = scaleSize;
            this.color = color;
            this.shadowColor = shadowColor;
        }
        /// <summary>
        /// 是否开启 默认开启
        /// </summary>
        public bool show = true;

        /// <summary>
        /// 循环动画，默认开启
        /// </summary>
        public bool loop = true;

        /// <summary>
        /// 运动周期，无单位，值越大越慢，默认为15 
        /// </summary>
        public int period = 15;

        /// <summary>
        ///  放大倍数，以markLine lineWidth为基准 
        /// </summary>
        public int scaleSize = 2;

        /// <summary>
        /// 炫光颜色，默认跟随markLine itemStyle定义颜色
        /// </summary>
        public string color = "";

        /// <summary>
        /// 光影颜色，默认跟所color
        /// </summary>
        public string shadowColor = "";

        /// <summary>
        /// 光影模糊度 默认根据scaleSize计算
        /// </summary>
        public int shadowBlur = 0;

        string format = @"
                {
                    show: {0},
                    loop: {1},
                    period: {2},
                    scaleSize : {3},
                    {4}
                    {5}
                    shadowBlur : {6}
                }
";

        public string GetEffectString()
        {
            string strColor = "";
            if(!string.IsNullOrEmpty(color))
            {
                strColor = "color : '" + color + "',";
            }
            string strShadow = "";
            if(!string.IsNullOrEmpty(shadowColor))
            {
                strShadow = "shadowColor : '"+shadowColor+"',";
            }

            
            return Util.Format(format,
                show,
                loop,
                period,
                scaleSize,
                strColor,
                strShadow,
                shadowBlur);
        }
    }
}
