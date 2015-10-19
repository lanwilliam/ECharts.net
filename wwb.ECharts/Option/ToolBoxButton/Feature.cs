/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 工具箱按钮设定
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 启用功能，目前支持feature见下
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// 辅助线按钮
        /// </summary>
        public Mark Mark
        { set; get; }

        /// <summary>
        /// 数据缩放按钮
        /// </summary>
        public DataZoom DataZoom
        { set; get; }

        /// <summary>
        /// 还原按钮
        /// </summary>
        public Restore Restore
        { set; get; }

        /// <summary>
        /// 保存图片按钮
        /// </summary>
        public SaveAsImage SaveAsImage
        { set; get; }

        /// <summary>
        /// 图表类型变换，请先自行实验或对照EchartsAPI，确认支持哪些
        /// bar，line应该没问题其他自行测试，需要满足的数据条件不同
        /// </summary>
        public MagicType MagicType
        { set; get; }
    }
}
