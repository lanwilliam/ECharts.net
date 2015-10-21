/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using wwb.ECharts.Option;

namespace wwb.ECharts.Option
{
    public class YAxis: Axis
    {
        /// <summary>
        /// 以数组形式返回对象，方便单个对象使用
        /// 请根据情况使用
        /// </summary>
        /// <returns></returns>
        public YAxis[] ToArray()
        {
            YAxis[] arr = new YAxis[1];
            arr[0] = this;
            return arr;
        }
    }
}
