using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class SeriesData
    {
        public List<Series> seriesList = new List<Series>();

        /// <summary>
        /// 返回series集合字符串不包含series : 
        /// </summary>
        /// <returns></returns>
        public string GetSeriesArrayString()
        {
            StringBuilder sb = new StringBuilder();



            foreach (Series s in seriesList)
            {
                sb.Append(s.GetSeriesString() + ",");
            }

            string str = sb.ToString();

            //  避免报错
            if (str.Length == 0)
                str = " ";

            str = str.Substring(0, str.Length - 1);

            return "[ " + str + " ]";
        }
    }
}
