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
    /// 力导向图的边数据, 每一项都有 source, target, weight三个属性, source和target是顶点的索引值， 边的权重(weight)越大则两个顶点之间的联系越大(最后稳定之后的距离越小)
    /// </summary>
    public class Links
    {
        /// <summary>
        /// 源节点的index或者源节点的name
        /// </summary>
        public Number? Source
        { get; set; }
        /// <summary>
        /// 目标节点的index或者目标节点的name
        /// </summary>
        public Number? Target
        { get; set; }

        /// <summary>
        /// 边的权重
        /// </summary>
        public Number? Weight
        { get; set; }
    }
}
