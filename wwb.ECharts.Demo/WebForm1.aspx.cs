using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wwb.ECharts;
using wwb.ECharts.Option;
using wwb.ECharts.Helpers;
using wwb.ECharts.Enums;
using System.Drawing;

namespace wwb.ECharts.Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EChart chart = EChartsCtrl1.chart;
            chart.IsExtendMap = true;
            chart.SVGPath = "svg/jinzhongBuilding.svg";
            Title title = new Title();
            title.Text = "测试用";
            title.TextStyle = new TextStyle();
            title.TextStyle.Color = Color.Aqua;

            chart.SetTitle(title);

            Legend legend = new Legend();
            legend.BackgroundColor = Color.AntiqueWhite;
            legend.Data = new string[] { "group1" };

            chart.SetLegend(legend);

            chart.SetColor(new Color[] { Color.Blue });

            ToolBox tb = new ToolBox();
            tb.Show = true;
            tb.Feature = new Option.ToolBoxButton.Feature();
            tb.Feature.Mark = new Option.ToolBoxButton.Mark();
            tb.Feature.Mark.Show = true;

            tb.Feature.Restore = new Option.ToolBoxButton.Restore();
            tb.Feature.Restore.Show = true;

            tb.Feature.SaveAsImage = new Option.ToolBoxButton.SaveAsImage();
            tb.Feature.SaveAsImage.Show = true;
            chart.SetToolBox(tb);

            wwb.ECharts.Option.ToolTip tt = new wwb.ECharts.Option.ToolTip();
            tt.Trigger = TriggerType.Item;
            tt.Formatter = "{b}";
            chart.SetToolTip(tt);



            Series s1 = new Series();
            s1.Data = "";
            s1.Name = "group1";
            s1.ItemStyle = new ItemStyle();
            s1.ItemStyle.Normal = new Normal();
            s1.ItemStyle.Normal.Color = Color.Gold;
            s1.ItemStyle.Normal.Label = new wwb.ECharts.Option.Label();
            s1.ItemStyle.Normal.Label.Show = true;
            s1.ItemStyle.Emphasis = new Emphasis();
            s1.ItemStyle.Emphasis.Label = new wwb.ECharts.Option.Label();
            s1.ItemStyle.Emphasis.Label.Show = true;
            s1.Type = EChartsTypes.Map;
            s1.Roam = true;
            s1.MarkPoint = new MarkPoint();
            s1.MarkPoint.Symbol = SymbolType.Circle;
            s1.MarkPoint.SymbolSize = 3;

            List<MarkPointDataItem> list = new List<MarkPointDataItem>();
            list.Add(new MarkPointDataItem("张三", 44, 71));
            list.Add(new MarkPointDataItem("李四", 84, 71));

            s1.MarkPoint.Data = list.ToArray();

            s1.MarkLine = new MarkLine();
            s1.MarkLine.Effect = new Effect();
            s1.MarkLine.Effect.Show = true;
            s1.MarkLine.Effect.Loop = true;
            s1.MarkLine.Effect.Color = Color.HotPink;
            s1.MarkLine.Symbol = new SymbolType[] { SymbolType.Circle, SymbolType.Arrow };
            s1.MarkLine.ItemStyle = new ItemStyle();
            s1.MarkLine.ItemStyle.Normal = new Normal();
            s1.MarkLine.ItemStyle.Normal.BorderWidth = 1;
            s1.MarkLine.ItemStyle.Normal.LineStyle = new LineStyle();
            s1.MarkLine.ItemStyle.Normal.LineStyle.Type = LineStyleType.Solid;

            //List<MarkLineDataItem> lineList = new List<MarkLineDataItem>();
            //lineList.Add(new MarkLineDataItem(new MarkPointDataItem("A", 88, 222), new MarkPointDataItem("B", 44, 232)));
            //s1.MarkLine.Data = lineList.ToArray();
            MarkPointDataItem[,] lineArr = {
                                                {new MarkPointDataItem("A", 88, 222), new MarkPointDataItem("B", 44, 232)},
                                                {new MarkPointDataItem("C", 123, 222), new MarkPointDataItem("D", 123, 282)}
                                            };
            s1.MarkLine.Data = lineArr;


            Series s2 = new Series();
            s2.Data = "";
            s2.Type = EChartsTypes.Map;
            s2.MarkPoint = new MarkPoint();
            s2.MarkPoint.Effect = new Effect();
            s2.MarkPoint.Effect.Show = true;
            s2.MarkPoint.Effect.ScaleSize = 8;
            s2.MarkPoint.Effect.Color = Color.DeepSkyBlue;
            s2.MarkPoint.Data = (new List<MarkPointDataItem>() { new MarkPointDataItem("MMM", 33, 99), new MarkPointDataItem("aaaaaaaa", 66, 123) }).ToArray();
            s2.MarkPoint.Symbol = SymbolType.EmptyDiamond;
            List<Series> slist = new List<Series>();
            slist.Add(s1);
            slist.Add(s2);
            chart.SetSeries(slist.ToArray());
        }
    }
}