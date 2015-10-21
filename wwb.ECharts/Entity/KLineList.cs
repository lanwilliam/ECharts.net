/**
 * 作者：王文斌
 * 做成日期：2015-10-20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Entity
{
    /// <summary>
    /// K线图数据集合
    /// </summary>
    public class KLineList
    {
        private List<KLineItem> list = new List<KLineItem>();

        public void Clear()
        {
            list.Clear();
        }

        public void Add(KLineItem item)
        {
            list.Add(item);
        }

        public void Remove(KLineItem item)
        {
            list.Remove(item);
        }

        /// <summary>
        /// 转化坐标轴数据
        /// </summary>
        /// <returns></returns>
        public string[] ToAxisData()
        {
            List<string> rtn = new List<string>();
            foreach(KLineItem item in list)
            {
                
                rtn.Add(item.Text);
            }
            return rtn.ToArray();
        }

        /// <summary>
        /// 转化坐标轴数据
        /// </summary>
        /// <returns></returns>
        public string ToAxisDataString()
        {
            string rtn = "";
            foreach (KLineItem item in list)
            {
                rtn += "\"" + item.Text + "\",";
            }
            if (rtn.Length > 0)
                rtn = rtn.Substring(0, rtn.Length - 1);
            return "[" + rtn + "]";
        }

        /// <summary>
        /// 转化序列数据
        /// </summary>
        /// <returns></returns>
        public string ToSeriesDataString()
        {
            string rtn = "";
            foreach(KLineItem item in list)
            {
                rtn += "["+item.StartPoint+","+item.EndPoint+","+item.MinPoint+","+item.MaxPoint+"],";
            }
            if (rtn.Length > 0)
                rtn = rtn.Substring(0, rtn.Length - 1);
            return "[" + rtn + "]";
        }

        /// <summary>
        /// 转化序列数据
        /// </summary>
        /// <returns></returns>
        public object ToSeriesData()
        {
            List<double[]> rtn = new List<double[]>();
            foreach (KLineItem item in list)
            {
                List<double> il = new List<double>();
                il.Add(item.StartPoint);
                il.Add(item.EndPoint);
                il.Add(item.MinPoint);
                il.Add(item.MaxPoint);
                rtn.Add(il.ToArray());
                
            }

            return rtn.ToArray();
        }
    }

    /// <summary>
    /// K线图数据对象
    /// </summary>
    public class KLineItem
    {
        public KLineItem()
        { }

        public KLineItem(string text,double start,double end,double min,double max)
        {
            this.Text = text;
            this.StartPoint = start;
            this.EndPoint = end;
            this.MinPoint = min;
            this.MaxPoint = max;
        }
        /// <summary>
        /// 显示文本，多用于XAxis
        /// </summary>
        public string Text { set; get; }

        /// <summary>
        /// 开盘点数
        /// </summary>
        public double StartPoint { set; get; }

        /// <summary>
        /// 收盘点数
        /// </summary>
        public double EndPoint { set; get; }

        /// <summary>
        /// 最高点数
        /// </summary>
        public double MaxPoint { set; get; }

        /// <summary>
        /// 最低点数
        /// </summary>
        public double MinPoint { set; get; }

        
    }
}
