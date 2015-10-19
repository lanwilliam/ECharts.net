using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class MakePoint
    {
        public MakePoint() { }

        /// <summary>
        /// 设置effect效果
        /// </summary>
        /// <param name="eff"></param>
        public MakePoint(Effect eff)
        {
            this.effect = eff;
        }

        /// <summary>
        /// 设置effect效果和点大小
        /// </summary>
        /// <param name="eff"></param>
        /// <param name="symbolSize"></param>
        public MakePoint(Effect eff, int symbolSize)
        {
            this.symbolSize = symbolSize;
            this.effect = eff;
        }

        /// <summary>
        /// 标点大小 默认3
        /// </summary>
        public int symbolSize = 3;

        /// <summary>
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        /// 'circle' | 'rectangle' | 'triangle' | 'diamond' |
        /// 'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond' 
        /// 另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星 
        /// 自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        /// 'circle' | 'rectangle' | 'triangle' | 'diamond' |
        /// 'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond' 
        /// 另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星 
        /// 自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        public string symbol = "circle";

        /// <summary>
        /// 设置展示效果 
        /// </summary>
        public Effect effect = new Effect();

        /// <summary>
        /// 清除标记点动画效果
        /// </summary>
        public void RemoveEffect()
        {
            this.effect = null;
        }
        /// <summary>
        /// point集合
        /// </summary>
        public List<PointItem> data=new List<PointItem>();


        /// <summary>
        /// 获取GeoCoord节字符串 不包含geoCoord: 
        /// </summary>
        /// <returns></returns>
        public string GetGeoCoordString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("geoCoord: {");

            foreach(PointItem point in data)
            {
                sb.Append(point.GetGeoCoordString() + ",");
            }

            string GeoStr = sb.ToString();

            //  避免报错
            if (GeoStr.Length == 0)
                GeoStr = " ";

            GeoStr = GeoStr.Substring(0, GeoStr.Length - 1);

            return "{" + GeoStr + "}";
            //sb.Append("}");
        }

        /// <summary>
        /// 获得MakePointString 不包含markPoint : 
        /// </summary>
        /// <returns></returns>
        public string GetMakePointString()
        {
            StringBuilder sb1 = new StringBuilder();

            foreach(PointItem point in this.data)
            {
                sb1.Append(point.GetMakePointString()+",");
            }

            string data = sb1.ToString();

            //  避免报错
            if (data.Length == 0)
                data = " ";

            data = data.Substring(0, data.Length - 1);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("            {");
            //sb.Append("                symbol : '"+symbol+"',");
            //sb.Append("                symbolSize : "+symbolSize+",");
            //sb.Append("                effect : "+effect.GetEffectString()+",");
            //sb.Append("                data : [");
            //sb.Append("                    "+data);
            //sb.Append("                ]");
            //sb.Append("            }");

            string strEff = "";
            if(effect!=null)
            {
                strEff = "effect : "+effect.GetEffectString()+",";
            }

            string mpString = @"
            {
                symbol : '{0}',
                symbolSize : {1},
                {2}
                data : [
                    {3}
                ]
            }
";
            return Util.Format(mpString, symbol, symbolSize, strEff, data);
        }
    }
}
