using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wwb.ECharts.Enums;
using wwb.ECharts.Option;

namespace wwb.ECharts.Demo
{
    public partial class Line : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EChart chart = EChartsCtrl1.chart;
            Title title = new Title();
            title.Text = "未来一周气温变化";
            title.Subtext = "纯属虚构";
            chart.SetTitle(title);

            ToolTip tt = new ToolTip();
            tt.Trigger = TriggerType.Axis;
            chart.SetToolTip(tt);

            Legend leg = new Legend();
            leg.Data = new string[] {"最高气温","最低气温" };
            chart.SetLegend(leg);

            ToolBox tb = new ToolBox();
            tb.Show = true;
            tb.Feature.Mark.Show = true;
            tb.Feature.Restore.Show = true;
            tb.Feature.SaveAsImage.Show = true;
            tb.Feature.MagicType.Show = true;
            tb.Feature.MagicType.Type = new string[] {"line","bar" };
            chart.SetToolBox(tb);

            chart.Calculable = true;

            XAxis xa = new XAxis();
            xa.Type = AxisType.Category;
            xa.BoundaryGap = new Helpers.BoundaryGapType("false");
            xa.Data = new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" };
            chart.SetXAxis(xa.ToArray());

            YAxis ya = new YAxis();
            ya.Type = AxisType.Value;
            ya.AxisLabel = new Option.Label();
            ya.AxisLabel.Formatter = "{value}°C";
            chart.SetYAxis(ya.ToArray());

            List<Series> list = new List<Series>();

            Series s1 = new Series();
            s1.Name = "最高气温";
            s1.Type = EChartsTypes.Line;
            s1.Data = new int[] {11,11,15,13,12,13,10 };
            s1.MarkPoint = new MarkPoint();
            s1.MarkPoint.Data = new MarkPointDataItem[] {
                new MarkPointDataItem(){Type="max",Name="最大值"},
                new MarkPointDataItem(){Type="min",Name="最小值"}
            };
            s1.MarkLine = new MarkLine();
            s1.MarkLine.Data=new MarkPointDataItem[]{
                                                new MarkPointDataItem(){Type="average",Name="平均值"}
                                            };
            list.Add(s1);
            Series s2 = new Series();
            s2.Name = "最低气温";
            s2.Type = EChartsTypes.Line;
            s2.Data = new int[] { 1, -2, 2, 5, 3, 2, 0 };
            s2.MarkPoint = new MarkPoint();
            s2.MarkPoint.Data = new MarkPointDataItem[] {
                new MarkPointDataItem(){Name="周最低",Value=-2,X=1,Y=-1.5}
            };
            s2.MarkLine = new MarkLine();
            s2.MarkLine.Data = new MarkPointDataItem[] { 
                new MarkPointDataItem(){Type="average",Name="平均温度"}
            };

            list.Add(s2);

            chart.SetSeries(list.ToArray());
        }
    }
}