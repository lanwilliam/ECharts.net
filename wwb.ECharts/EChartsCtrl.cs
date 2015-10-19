/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 为方便使用，封装成web控件，直接拖拽使用即可
 * 在控件load前，完成设置
 * 更高级用法可以自行处理，直接使用ECharts类
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace wwb.ECharts
{
    public class EChartsCtrl : Control
    {
        private int _tWidth = 800;
        private int _tHeight = 600;


        [Browsable(true)]//在属性窗口中是否可见
        [Category("Appearance")]//属性的分类，如，行为，外观，大家可以在属性窗口看见这样的分类
        [DefaultValue(800)]//属性的默认值
        [Description("表格宽度")]//这些是显示在属性窗口底下的
        public int Width
        {
            get { return _tWidth; }
            set { _tWidth = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(600)]
        [Description("表格高度")]
        public int Height
        {
            get { return _tHeight; }
            set { _tHeight = value; }
        }
        EChart _chart = new EChart("mainMap");
        public EChart chart
        {
            get { return _chart; }
        }

        

        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write(string.Format("<div id='mainMap' style='width:{0}px; height:{1}px; '></div>",this._tWidth,this._tHeight));
            
            writer.Write(_chart.toHtmlString());
            base.Render(writer);
        }
    }
}
