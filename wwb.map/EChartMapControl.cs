using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace wwb.map
{
    public class EChartMapControl:Control
    {
        private int _tWidth = 100;
        private int _tHeight = 100;


        [Browsable(true)]//在属性窗口中是否可见
        [Category("Appearance")]//属性的分类，如，行为，外观，大家可以在属性窗口看见这样的分类
        [DefaultValue(100)]//属性的默认值
        [Description("表格宽度")]//这些是显示在属性窗口底下的
        public int Width
        {
            get { return _tWidth; }
            set { _tWidth = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(100)]
        [Description("表格高度")]
        public int Height
        {
            get { return _tHeight; }
            set { _tHeight = value; }
        }

        private EChartsMapMaker mapMaker=new EChartsMapMaker();

        /// <summary>
        /// MapMaker
        /// </summary>
        public EChartsMapMaker MapMaker
        {
            get { return mapMaker; }
            set { mapMaker = value; }
        }

        string html = @"
    <div id='mainMap' style='width:{0}px; height:{1}px; '></div>
    <script type='text/javascript'>
        // 自定义扩展图表类型：
        {2}
        // option
        {3}
        var myChart = echarts.init(document.getElementById('mainMap'));
        // 为echarts对象加载数据 
        myChart.setOption(option,true);
    </script>
";
        protected override void Render(HtmlTextWriter writer)
        {
            //string outhtml = Util.Format(html, 
            //    Width, 
            //    Height, 
            //    MapMaker.GetAjaxCallBackStrinig(), 
            //    MapMaker.GetOptionString());

            string outhtml = Util.Format(html,
                    Width,
                Height,
                MapMaker.GetAjaxCallBackStrinig(),
                MapMaker.GetOptionString());
            writer.Write(outhtml);
            base.Render(writer);
        }

    }
}
