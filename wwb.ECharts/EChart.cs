/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * Echarts主类，主要处理Option各种设置
 * 未完全实现，部分特殊类型待处理
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Option;
using System.Drawing;

namespace wwb.ECharts
{
    public class EChart
    {
        internal string Name;
        internal IDictionary<string, string> JsVariables { get; private set; }
        internal IDictionary<string, string> JsFunctions { get; private set; }

        Title _Title;
        Legend _Legend;
        //DataRange _DataRange;
        ToolBox _ToolBox;
        ToolTip _ToolTip;
        //DataZoom _DataZoom;
        Grid _Grid;
        XAxis[] _XAxis;
        YAxis[] _YAxis;
        Series[] _Series;
        Color[] _Color;
        private bool calculable=false;

        /// <summary>
        /// 是否启用拖拽重计算特性，默认关闭
        /// </summary>
        public bool Calculable
        {
            get { return calculable; }
            set { calculable = value; }
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">初始化容器名[DIV id]</param>
        public EChart(string name)
        {
            Name = name;
            JsVariables = new Dictionary<string, string>();
            JsFunctions = new Dictionary<string, string>();

        }

        public EChart SetTitle(Title title)
        {
            _Title = title;
            return this;
        }

        public EChart SetLegend(Legend legend)
        {
            _Legend = legend;
            return this;
        }

        //public EChart SetDataRange(DataRange datarange)
        //{
        //    _DataRange = datarange;
        //    return this;
        //}

        public EChart SetToolBox(ToolBox toolbox)
        {
            _ToolBox = toolbox;
            return this;
        }

        public EChart SetToolTip(ToolTip tooltip)
        {
            _ToolTip = tooltip;
            return this;
        }

        //public EChart SetDataZoom(DataZoom datazoom)
        //{
        //    _DataZoom = datazoom;
        //    return this;
        //}
        public EChart SetGrid(Grid grid)
        {
            _Grid = grid;
            return this;
        }
        public EChart SetXAxis(XAxis[] xaxis)
        {
            _XAxis = xaxis;
            return this;
        }
        public EChart SetYAxis(YAxis[] yaxis)
        {
            _YAxis = yaxis;
            return this;
        }
        public EChart SetSeries(Series[] series)
        {
            _Series = series;
            return this;
        }
        public EChart SetColor(Color[] color)
        {
            _Color = color;
            return this;
        }

        /// <summary>
        /// SVG地图文件路径 设置IsExtendMap后必填
        /// </summary>
        public string SVGPath
        { set; get; }

        /// <summary>
        /// 设置是否是扩展地图 是会输出扩展方法脚本
        /// </summary>
        public bool IsExtendMap
        { set; get; }

        public string toHtmlString()
        {
            StringBuilder script = new StringBuilder();
            script.AppendLine("<script type='text/javascript'>");

            if(IsExtendMap)
            {
                script.AppendLine("echarts.util.mapData.params.params.WangwbMap = {");
                script.AppendLine("getGeoJson: function (callback) {");
                script.AppendLine("$.ajax({");
                script.Append("url: '"); script.Append(SVGPath); script.AppendLine("',");
                script.AppendLine("dataType: 'xml',");
                script.AppendLine("success: function (xml) {");
                script.AppendLine("callback(xml)");
                script.AppendLine("}");
                script.AppendLine("});");
                script.AppendLine("}");
                script.AppendLine("};");

            }
            script.AppendLine("var myChart = echarts.init(document.getElementById('{0}'));".FormatWith(Name));
            script.AppendLine(" var option = ");
            script.AppendEChart(this);
            script.AppendLine("myChart.setOption(option);");
            script.AppendLine("</script>");
            return script.ToString();
        }




        public string GetOptions()
        {
            StringBuilder options = new StringBuilder();

            if (_Title != null)
            {
                options.Append("title: {0}".FormatWith(JsonSerializer.Serialize(_Title)), 2);
                options.AppendLine(", ");
            }
            if (_Legend != null)
            {
                options.Append("legend: {0}".FormatWith(JsonSerializer.Serialize(_Legend)), 2);
                options.AppendLine(", ");
            }
            
            //if (_DataRange != null)
            //{
            //    options.Append("dataRange: {0}".FormatWith(JsonSerializer.Serialize(_DataRange)), 2);
            //    options.AppendLine(", ");
            //}
            if (_ToolBox != null)
            {
                options.Append("toolbox: {0}".FormatWith(JsonSerializer.Serialize(_ToolBox)), 2);
                options.AppendLine(", ");
            }
            if (_ToolTip != null)
            {
                options.Append("tooltip: {0}".FormatWith(JsonSerializer.Serialize(_ToolTip)), 2);
                options.AppendLine(", ");
            }
            //if (_DataZoom != null)
            //{
            //    options.Append("dataZoom: {0}".FormatWith(JsonSerializer.Serialize(_DataZoom)), 2);
            //    options.AppendLine(", ");
            //}
            if (Calculable)
            {
                options.Append("calculable: {0}".FormatWith("true"));
                options.AppendLine(", ");
            }
            if (_Grid != null)
            {
                options.Append("grid: {0}".FormatWith(JsonSerializer.Serialize(_Grid)), 2);
                options.AppendLine(", ");
            }
            if(_XAxis != null)
            {
                options.Append("xAxis: {0}".FormatWith(JsonSerializer.Serialize(_XAxis)), 2);
                options.AppendLine(", ");
            }
            if(_YAxis != null)
            {
                options.Append("yAxis: {0}".FormatWith(JsonSerializer.Serialize(_YAxis)), 2);
                options.AppendLine(", ");
            }
            if (_Color != null)
            {
                options.Append("color: {0}".FormatWith(JsonSerializer.Serialize(_Color)), 2);
                options.AppendLine(", ");
            }
            if (_Series != null)
            {
                options.Append("series: {0}".FormatWith(JsonSerializer.Serialize(_Series)), 2);
                options.AppendLine(", ");
            }

            options.AppendLine();

            return options.ToString();
        }
    }
}
