using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wwb.ECharts.Entity;
using wwb.ECharts.Option;
namespace wwb.ECharts.Demo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title title = new Option.Title();
            title.Text = "某站点用户访问来源";
            title.Subtext = "纯属虚构";
            title.X = Enums.XAlign.Center;
            EChartsCtrl1.chart.SetTitle(title);

            ToolTip tt = new ToolTip();
            tt.Trigger = Enums.TriggerType.Item;
            tt.Formatter = "{a} <br/>{b} : {c} ({d}%)";
            EChartsCtrl1.chart.SetToolTip(tt);

            Legend legend = new Legend();
            legend.Orient=Enums.OrientType.Vertical;
            legend.X = Enums.XAlign.Left;
            legend.Data = new string[] { "直接访问", "邮件营销", "联盟广告", "视频广告", "搜索引擎" };
            EChartsCtrl1.chart.SetLegend(legend);

            ToolBox tb = new ToolBox();
            tb.Show = true;
            tb.Feature = new Option.ToolBoxButton.Feature();
            tb.Feature.Mark = new Option.ToolBoxButton.Mark();
            tb.Feature.Mark.Show = true;
            tb.Feature.MagicType = new Option.ToolBoxButton.MagicType();
            tb.Feature.MagicType.Show = true;
            tb.Feature.MagicType.Type = new string[] {Enums.EChartsTypes.Pie.ToString().ToLower(),
                Enums.EChartsTypes.Funnel.ToString().ToLower()
            };
            tb.Feature.MagicType.Option = new Option.ToolBoxButton.Option();
            tb.Feature.MagicType.Option.Funnel = new Option.ToolBoxButton.Funnel();
            tb.Feature.MagicType.Option.Funnel.FunnelAlign = Enums.XAlign.Left;
            tb.Feature.MagicType.Option.Funnel.X = "25%";
            tb.Feature.MagicType.Option.Funnel.Width = "50%";
            tb.Feature.MagicType.Option.Funnel.Max = 1548;

            tb.Feature.Restore = new Option.ToolBoxButton.Restore();
            tb.Feature.Restore.Show = true;
            tb.Feature.SaveAsImage = new Option.ToolBoxButton.SaveAsImage();
            tb.Feature.SaveAsImage.Show = true;
            EChartsCtrl1.chart.SetToolBox(tb);

            EChartsCtrl1.chart.Calculable = true;

            List<Series> list = new List<Series>();
            Series s = new Series();
            s.Name = "访问来源";
            s.Type = Enums.EChartsTypes.Pie;
            s.Radius = new string[]{"55%"};
            s.Center = new string[] {"50%","60%" };
            s.Data = new PieDataItem[] { 
                new PieDataItem(){Name="直接访问",Value=335},
                new PieDataItem(){Name="邮件营销",Value=311},
                new PieDataItem(){Name="联盟广告",Value=234},
                new PieDataItem(){Name="视频广告",Value=135},
                new PieDataItem(){Name="搜索引擎",Value=1548},
            };
            list.Add(s);

            EChartsCtrl1.chart.SetSeries(list.ToArray());
        }
    }
}