using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wwb.ECharts.Option;

namespace wwb.ECharts.Demo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title title = new Option.Title();
            title.Text = "某地区蒸发量和降水量";
            title.Subtext = "纯属虚构";
            EChartsCtrl1.chart.SetTitle(title);

            ToolTip tt = new ToolTip();
            tt.Trigger = Enums.TriggerType.Axis;
            EChartsCtrl1.chart.SetToolTip(tt);

            Legend legend = new Legend();
            legend.Data = new string[] { "蒸发量", "降雨量" };
            EChartsCtrl1.chart.SetLegend(legend);

            ToolBox tb = new ToolBox();
            tb.Show = true;
            tb.Feature = new Option.ToolBoxButton.Feature();
            tb.Feature.Mark = new Option.ToolBoxButton.Mark();
            tb.Feature.Mark.Show = true;
            tb.Feature.MagicType = new Option.ToolBoxButton.MagicType();
            tb.Feature.MagicType.Show = true;
            tb.Feature.MagicType.Type = new string[] {Enums.EChartsTypes.Line.ToString().ToLower(),
                Enums.EChartsTypes.Bar.ToString().ToLower()
            };
            tb.Feature.Restore = new Option.ToolBoxButton.Restore();
            tb.Feature.Restore.Show = true;
            tb.Feature.SaveAsImage = new Option.ToolBoxButton.SaveAsImage();
            tb.Feature.SaveAsImage.Show = true;
            EChartsCtrl1.chart.SetToolBox(tb);

            EChartsCtrl1.chart.Calculable = true;

            XAxis[] x = new XAxis[1];
            x[0] = new XAxis();
            x[0].Type = Enums.AxisType.Category;
            x[0].Data = new string[] {
                "1月","2月","3月","4月","5月","6月","7月","8月","9月","10月","11月","12月"
            };

            EChartsCtrl1.chart.SetXAxis(x);

            YAxis[] y = new YAxis[1];
            y[0] = new YAxis();
            y[0].Type = Enums.AxisType.Value;
            EChartsCtrl1.chart.SetYAxis(y);

            Series zf = new Series();
            zf.Name = "蒸发量";
            zf.Type = Enums.EChartsTypes.Bar;
            zf.Data = new double[] {2.0,4.9,7.0,23.2,76.7,135.6,162.5,32.3,20.0,6.4,5.3,3.0 };
            zf.MarkPoint = new MarkPoint();
            zf.MarkPoint.Data = new MarkPointDataItem[] {
                new MarkPointDataItem(){Type="max",Name="最大值"},
                new MarkPointDataItem(){Type="min",Name="最小值"}
            };
            zf.MarkLine = new MarkLine();
            MarkPointDataItem[] lineArr = {
                                                new MarkPointDataItem(){Type="average",Name="平均值"}
                                                
                                            };
            zf.MarkLine.Data = lineArr;

            Series jy = new Series();
            jy.Name = "降雨量";
            jy.Type = Enums.EChartsTypes.Bar;
            jy.Data = new double[] { 2.5, 5.9, 9.0, 25.2, 86.7, 125.6, 152.5, 62.3, 30.0, 16.4, 13.3 ,6.6};
            jy.MarkPoint = new MarkPoint();
            jy.MarkPoint.Data = new MarkPointDataItem[] {
                new MarkPointDataItem(){Name="年最高",Type="max"},
                new MarkPointDataItem(){Name="年最低",Type="min"}
            };
            jy.MarkLine = new MarkLine();
            MarkPointDataItem[] lineArr2 = {
                                                new MarkPointDataItem(){Type="average",Name="平均值"}
                                                
                                            };
            jy.MarkLine.Data = lineArr2;

            List<Series> ls = new List<Series>();
            ls.Add(zf);
            ls.Add(jy);

            EChartsCtrl1.chart.SetSeries(ls.ToArray());



            
        }
    }
}