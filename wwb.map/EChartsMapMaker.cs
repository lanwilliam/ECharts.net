using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class EChartsMapMaker
    {
        /// <summary>
        /// 背景颜色 例 #eee
        /// </summary>
        public string backgroundColor = "#eee";

        /// <summary>
        /// 标题
        /// </summary>
        public Title title = new Title();

        /// <summary>
        /// tooltip
        /// </summary>
        public Tooltip tooltip = new Tooltip();

        /// <summary>
        /// 数据序列集合
        /// </summary>
        public SeriesData seriesData = new SeriesData();

        /// <summary>
        /// 工具条
        /// </summary>
        public Toolbox toolbox = new Toolbox();

        /// <summary>
        /// 获取颜色字符串
        /// </summary>
        /// <returns></returns>
        public string GetColor()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Series s in seriesData.seriesList)
            {
                sb.Append("'" + s.color + "'" + ",");
            }
            string str = sb.ToString();
            
            //  避免报错
            if (str.Length == 0)
                str = " ";

            str = str.Substring(0, str.Length - 1);
            return "[" + str + "]";
        }

        /// <summary>
        /// 获取Legend字符串
        /// </summary>
        /// <returns></returns>
        public string GetLegend()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Series s in seriesData.seriesList)
            {
                sb.Append("'" + s.name + "'" + ",");
            }
            string str = sb.ToString();

            //  避免报错
            if (str.Length == 0)
                str = " ";

            str = str.Substring(0, str.Length - 1);
            return "[" + str + "]";
        }

        string format = @"
option = {
    backgroundColor:'{0}',
    title : {1},
    tooltip : {2},
    color: {3},
    legend:{data:{4} },
    toolbox: {5},
    series : {6}
};
";
        public string GetOptionString()
        {
            return Util.Format(format,
                backgroundColor,
                title.GetTitleString(),
                tooltip.GetTooltipString(),
                GetColor(),
                GetLegend(),
                toolbox.GetJSONString(),
                seriesData.GetSeriesArrayString()
                );
        }

        /// <summary>
        /// 加载的svg文件的路径
        /// </summary>
        public string svgPath="";


        string ajaxformat = @"
        echarts.util.mapData.params.params.GlodBellMap = {
            getGeoJson: function (callback) {
                $.ajax({
                    url: '{0}',
                    dataType: 'xml',
                    success: function (xml) {
                        callback(xml)
                    }
                });
            }
        };
";

        /// <summary>
        /// 获取ajax回调js
        /// </summary>
        /// <returns></returns>
        public string GetAjaxCallBackStrinig()
        {
            return ajaxformat.Replace("{0}",svgPath);
        }


    }
}
