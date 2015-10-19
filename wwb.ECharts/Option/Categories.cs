/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 力导向图中节点的分类, 每一项有name和itemStyle两个属性
    /// </summary>
    public class Categories
    {
        public string Name
        { get; set; }

        public ItemStyle ItemStyle
        { get; set; }
    }
}
