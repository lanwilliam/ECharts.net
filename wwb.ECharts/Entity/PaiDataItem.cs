/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 说明：饼图数据实体
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wwb.ECharts.Helpers;

namespace wwb.ECharts.Entity
{
    public class PieDataItem
    {
        public string Name { set; get; }
        public Number Value { set; get; }
    }
}
