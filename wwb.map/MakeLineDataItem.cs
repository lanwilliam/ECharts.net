using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class MakeLineDataItem
    {
        public MakeLineDataItem() { }

        public MakeLineDataItem(PointItem from, PointItem to)
        {
            this.from = from;
            this.to = to;
        }
        /// <summary>
        /// 连线 起点
        /// </summary>
        public PointItem from=new PointItem();

        /// <summary>
        /// 连线终点
        /// </summary>
        public PointItem to=new PointItem();
        string format = @"
                    [
                        {name:'{0}', geoCoord: [{1}, {2}]}, 
                        {name:'{3}', geoCoord: [{4}, {5}]}
                    ]
";
        public string GetDataItemString()
        {
            return Util.Format(format, from.name,from.Geo.X,from.Geo.Y, to.name,to.Geo.X,to.Geo.Y);
        }
    }
}
