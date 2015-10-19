using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class MakeLine
    {
        /// <summary>
        /// 默认函数
        /// </summary>
        public MakeLine()
        { }

        /// <summary>
        /// 设置Effect效果
        /// </summary>
        /// <param name="eff"></param>
        public MakeLine(Effect eff)
        {
            this.effect = eff;
        }
        /// <summary>
        /// 平滑曲线显示，默认true。smooth为true时lineStyle不支持虚线
        /// </summary>
        public bool smooth = true;

        /// <summary>
        /// 设置展示效果
        /// </summary>
        public Effect effect = new Effect();

        /// <summary>
        /// 线条类型 默认['circle', 'arrow'] 可以用['none']
        /// </summary>
        public string symbol = "['circle', 'arrow']";

        /// <summary>
        /// 线条粗细 默认1
        /// </summary>
        public int LineWidth = 1;

        /// <summary>
        /// 线条类型默认solid 可选为：'solid' | 'dotted' | 'dashed'
        /// </summary>
        public string LineType = "solid";

        string itFormat = @"
                {
                    normal: {
                        borderWidth:{0},
                        lineStyle: {
                            type: '{1}'
                        }
                    }
                }
";
        /// <summary>
        /// 获取ItemStyle String
        /// </summary>
        public string itemStyle
        {
            get { return Util.Format(itFormat, LineWidth, LineType); }
        }

        public List<MakeLineDataItem> data = new List<MakeLineDataItem>();

        string dataFmt = @"
                [
                    {0}
                ]
";
       
        public string GetLineDataString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(MakeLineDataItem item in data)
            {
                sb.Append(item.GetDataItemString() + ",");
            }

            string dStr = sb.ToString();

            //  避免报错
            if (dStr.Length == 0)
                dStr = " ";

            dStr = dStr.Substring(0, dStr.Length - 1);
            return Util.Format(dataFmt, dStr);
        }

        string mlFmt = @"
            {
                smooth:{0},
                effect : {1},
                symbol:{2},
                itemStyle : {3},
                data : {4}
            }
";
        /// <summary>
        /// 返回MakeLine字符串 不包含 markLine : 
        /// </summary>
        /// <returns></returns>
        public string GetMakeLineString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("            {");

            //sb.Append("                  smooth:" + smooth.ToString().ToLower() + ",");
            //if(effect!=null)
            //{
            //    sb.Append("                  effect:" + effect.GetEffectString() + ",");
            //}
            //sb.Append("                  symbol:" + symbol + ",");
            //sb.Append("                  itemStyle : " + itemStyle + ",");
            //sb.Append("                  data : " + GetLineDataString());

            //sb.Append("            }");

            //return sb.ToString();

            return Util.Format(mlFmt,
                smooth,
                effect.GetEffectString(),
                symbol,
                itemStyle,
                GetLineDataString());
        }
    }
}
