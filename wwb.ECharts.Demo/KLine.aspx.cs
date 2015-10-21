/**
 * 作者：王文斌
 * 做成日期：2015-10-20
 * */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wwb.ECharts;
using wwb.ECharts.Option;
using wwb.ECharts.Helpers;
using wwb.ECharts.Enums;
using wwb.ECharts.Entity;
using System.Text;

namespace wwb.ECharts.Demo
{
    public partial class KLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KLineList list = InitData();
            EChart chart = EChartsCtrl1.chart;

            Title title = new Title();
            title.Text = "2013年上半年上证指数";
            title.TextStyle = new TextStyle();
            title.TextStyle.Color = Color.Aqua;
            chart.SetTitle(title);

            ToolTip tt = new ToolTip();
            tt.Trigger = TriggerType.Axis;
            StringBuilder sbf = new StringBuilder();
            sbf.Append("function (params) {");
            sbf.Append(" var res = params[0].seriesName + ' ' + params[0].name;");
            sbf.Append(" res += '<br/>  开盘 : ' + params[0].value[0] + '  最高 : ' + params[0].value[3];");
            sbf.Append(" res += '<br/>  收盘 : ' + params[0].value[1] + '  最低 : ' + params[0].value[2];");
            sbf.Append(" return res;");
            sbf.Append(" }");

            StringFormatter jsf = new StringFormatter();
            jsf.Formatter = sbf.ToString();
            jsf.isFunction = true;
            tt.Formatter = jsf;
////////            tt.Formatter = @"function (params) {
////////                var res = params[0].seriesName + ' ' + params[0].name;
////////                res += '<br/>  开盘 : ' + params[0].value[0] + '  最高 : ' + params[0].value[3];
////////                res += '<br/>  收盘 : ' + params[0].value[1] + '  最低 : ' + params[0].value[2];
////////                return res;
////////            }";
            chart.SetToolTip(tt);

            Legend leg = new Legend();
            leg.Data = new string[] {"上证指数" };
            chart.SetLegend(leg);

            ToolBox tb = new ToolBox();
            tb.Show = true;
            tb.Feature = new Option.ToolBoxButton.Feature();
            tb.Feature.Mark = new Option.ToolBoxButton.Mark();
            tb.Feature.Mark.Show = true;
            tb.Feature.DataZoom = new Option.ToolBoxButton.DataZoom();
            tb.Feature.DataZoom.Show = true;
            tb.Feature.MagicType = new Option.ToolBoxButton.MagicType();
            tb.Feature.MagicType.Show = true;
            tb.Feature.MagicType.Type = new string[] {"line","bar" };
            tb.Feature.Restore = new Option.ToolBoxButton.Restore();
            tb.Feature.Restore.Show = true;
            tb.Feature.SaveAsImage = new Option.ToolBoxButton.SaveAsImage();
            tb.Feature.SaveAsImage.Show = true;
            chart.SetToolBox(tb);

            XAxis xAxis = new XAxis();
            xAxis.Type = AxisType.Category;
            xAxis.BoundaryGap = new BoundaryGapType("true");
            xAxis.axisTick = new AxisTick();
            xAxis.axisTick.OnGap = false;
            xAxis.splitLine = new SplitLine();
            xAxis.splitLine.Show = false;
            xAxis.Data = list.ToAxisData();
            chart.SetXAxis(xAxis.ToArray());

            YAxis yAxis = new YAxis();
            yAxis.Type = AxisType.Value;
            yAxis.Scale = true;
            yAxis.BoundaryGap = new BoundaryGapType("[0.01,0.01]"); ;
            
            chart.SetYAxis(yAxis.ToArray());

            Series series = new Series();
            series.Name = "上证指数";
            series.Type = EChartsTypes.K;
            series.Data = list.ToSeriesData();

            chart.SetSeries(series.ToArray());
        }


        private KLineList InitData()
        {
            KLineList list = new KLineList();
            list.Add(new KLineItem("2013/1/24",2000,2500,1800,2600));
            list.Add(new KLineItem("2013/1/25", 2000, 2500, 1800, 2600));
            list.Add(new KLineItem("2013/1/26", 2100, 2400, 1500, 2600));
            list.Add(new KLineItem("2013/1/27", 2400, 2100, 1860, 2600));
            list.Add(new KLineItem("2013/1/28", 2010, 2500, 1700, 2600));
            list.Add(new KLineItem("2013/1/29", 2300, 2700, 2100, 3100));
            list.Add(new KLineItem("2013/1/30", 2600, 2580, 2200, 2900));
            list.Add(new KLineItem("2013/1/31", 2070, 2540, 1850, 2890));
            return list;
        }
    }
}