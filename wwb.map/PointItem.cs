using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class PointItem
    {
        /// <summary>
        /// 创建PointItem对象 需要手工设置name 和Geo
        /// </summary>
        public PointItem()
        { }

        /// <summary>
        /// 创建PointItem
        /// </summary>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public PointItem(string name,int x,int y)
        {
            this.name = name;
            this.Geo.X = x;
            this.Geo.Y = y;
        }
        /// <summary>
        /// 点名称
        /// </summary>
        public string name = "Point";

        /// <summary>
        /// 点坐标
        /// </summary>
        public Point Geo = new Point();

        /// <summary>
        /// 获取GeoCoordString 
        /// </summary>
        /// <returns> '杏花天': [676, 203]</returns>
        public string GetGeoCoordString()
        {
            return Util.Format("'{0}': [{1}, {2}]", name, Geo.X, Geo.Y);
        }

        /// <summary>
        /// 获取MakePointItemString
        /// </summary>
        /// <returns>{name: '叮叮'}</returns>
        public string GetMakePointString()
        {
            return "{name: '"+name+"'}";
        }
    }
}
