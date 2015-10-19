/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 辅助线文本
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 用来控制辅助线三个按钮文字
    /// </summary>
    public class MarkTitle
    {
        string mark = "辅助线开关";
        /// <summary>
        /// 辅助线开关
        /// </summary>
        public string Mark
        { set { this.mark = value; } get { return this.mark; } }

        string markUndo = "删除辅助线";
        /// <summary>
        /// 删除辅助线
        /// </summary>
        public string MarkUndo
        { set { this.markUndo = value; } get { return this.markUndo; } }

        string markClear = "清空辅助线";
        /// <summary>
        /// 清空辅助线
        /// </summary>
        public string MarkClear
        { set { this.markClear = value; } get { return this.markClear; } }


    }
}
