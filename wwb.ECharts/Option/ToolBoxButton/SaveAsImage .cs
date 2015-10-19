/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 图片另存为
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 保存图片（IE8-不支持）
    /// </summary>
    public class SaveAsImage
    {
        /// <summary>
        /// 显示按钮
        /// </summary>
        public bool? Show
        { set; get; }

        /// <summary>
        /// 按钮名称 保存为图片
        /// </summary>
        public string Title
        { set; get; }

        private string type = "png";
        /// <summary>
        /// 认保存图片类型为'png'，需要的话改为'jpeg'
        /// </summary>
        public string Type
        { set{this.type = value;} get{return this.type;}}
    }
}
