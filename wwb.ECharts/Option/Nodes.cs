/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 力导向图的顶点数据, 每一项都有 name, value, category三个属性，分别表示节点的名称， 节点的值和节点的分类
    /// </summary>
    public class Nodes
    {
        public string Name
        { get; set; }

        public Number? Value
        { get; set; }

        public Number? Category
        { get; set; }
    }
}
