using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    
    public class Series
    {
        public Series()
        { 
            
        }

        public Series(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        /// <summary>
        /// 默认green 设置参考 'rgba(100, 149, 237, 1)', 'green'
        /// </summary>
        public string color = "green";

        /// <summary>
        /// series 名称
        /// </summary>
        public string name = "";

        /// <summary>
        /// 类型 制定map，不可修改，本控件暂时不支持map以外类型
        /// </summary>
        public readonly string type="map";

        /// <summary>
        /// mapType 默认GlodBellMap不可修改
        /// </summary>
        public readonly string mapType = "GlodBellMap";

        /// <summary>
        /// 是否开启滚轮缩放和拖拽漫游.默认开启True。false（关闭），true（开启），'scale'（仅开启滚轮缩放），'move'（仅开启拖拽漫游）
        /// </summary>
        public string roam = "true";

        /// <summary>
        /// 数据默认[]不可修改
        /// </summary>
        public readonly string data = "[]";

        /// <summary>
        /// MakePoint集合，需要填充Point点，用于标注点
        /// </summary>
        public MakePoint makePoint = new MakePoint();

        /// <summary>
        /// 划线集合 LineItem中的from 和to 
        /// </summary>
        public MakeLine makeLine = new MakeLine();

        string format = @"
    {
            name: '{0}',
            type: '{1}',
            mapType: '{2}',
            roam:{3},
            itemStyle:{
                normal:{label:{show:true}},
                emphasis:{label:{show:true}}
            },
            data: {4},
            geoCoord: {5},
            markPoint:{6},
            markLine: {7}
    }
";

        /// <summary>
        /// 获取一个序列对象字符串
        /// </summary>
        /// <returns></returns>
        public string GetSeriesString()
        {
            // 允许添加不含序列名的序列对象，无名对象不生成上方索引项
            // 主要用来做热点或者固定点标注
            string smt = format;
            if(string.IsNullOrEmpty(name))
            {
                smt = smt.Replace("name: '{0}',", "");
            }

            return Util.Format(smt,
                name,
                type,
                mapType,
                roam,
                data,
                makePoint.GetGeoCoordString(),
                makePoint.GetMakePointString(),
                makeLine.GetMakeLineString()
                );
        }


    }
}
