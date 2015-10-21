/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * */
using System;
using wwb.ECharts.Helpers;
using wwb.ECharts.Enums;

namespace wwb.ECharts.Option
{
    /// <summary>
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据，其中个别选项仅在部分图表类型中有效
    /// </summary>
    public class Series
    {
        /// <summary>
        /// null   系列名称，如启用legend，该值将被legend.data索引相关
        /// </summary>
        public string Name
        { get; set; }

        /// <summary>
        /// null   提示框样式，仅对本系列有效，如不设则用option.tooltip（详见tooltip）,鼠标悬浮交互时的信息提示
        /// </summary>
        public ToolTip Tooltip
        { get; set; }

        /// <summary>
        /// null   图表类型，必要参数！如为空或不支持类型，则该系列数据不被显示。可选为：'line'（折线图） | 'bar'（柱状图） | 'pie'（饼图） | 'scatter'（散点图） | 'k'（K线图） | 'map'（地图）
        /// </summary>
        public EChartsTypes? Type
        { get; set; }

        /// <summary>
        /// null   图形样式
        /// </summary>
        public ItemStyle ItemStyle
        { get; set; }

        /// <summary>
        /// null   组合名称，多组数据的堆积图时使用，eg：stack:'group1'，则series数组中stack值等于'group1'的数据做堆积计算
        /// </summary>
        public string Stack
        { get; set; }

        /// <summary>
        /// 0   xAxis坐标轴数组的索引，指定该系列数据所用的横坐标轴
        /// </summary>
        public Number? XAxisIndex
        { get; set; }

        /// <summary>
        /// 0   yAxis坐标轴数组的索引，指定该系列数据所用的纵坐标轴
        /// </summary>
        public Number? YAxisIndex
        { get; set; }

        /// <summary>
        /// 20  柱条最小高度，防止某item的值过小而影响交互
        /// </summary>
        public Number? BarMinHeight
        { get; set; }

        /// <summary>
        /// 自适应   柱条宽度，不设时自适应
        /// </summary>
        public Number? BarWidth
        { get; set; }

        /// <summary>
        /// null   标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'）
        /// </summary>
        public SymbolType? Symbol
        { get; set; }

        /// <summary>
        /// 4    标志图形大小，可计算特性启用情况建议增大以提高交互体验。
        /// </summary>
        public Number? SymbolSize
        { get; set; }

        /// <summary>
        /// null     标志图形旋转角度[-180,180]
        /// </summary>
        public Number? SymbolRotate
        { get; set; }

        /// <summary>
        /// 圆心坐标，默认为[width / 2, height / 2]自适应居中
        /// </summary>
        public string[] Center
        { get; set; }

        /// <summary>
        /// 自适应    半径，默认为Min(width, height) / 2 - 50, 传数组实现环形图，[内半径，外半径]
        /// </summary>
        public string[] Radius
        { get; set; }

        /// <summary>
        /// 0   开始角度, 有效输入范围：[-180,180]
        /// </summary>
        public Number? StartAngle
        { get; set; }

        /// <summary>
        /// 5   最小角度，防止某item的值过小而影响交互
        /// </summary>
        public Number? MinAngle
        { get; set; }

        /// <summary>
        /// 10  选中是扇区偏移量
        /// </summary>
        public Number? SelectedOffset
        { get; set; }

        /// <summary>
        /// null    选中模式，默认关闭，可选single，multiple
        /// </summary>
        public SelectedModeType? SelectedMode
        { get; set; }

        private string maptype = "WangwbMap";
        /// <summary>
        /// 目前MapType写死为WangwbMap，暂不支持其他地图
        /// 回头有时间作者会尽量补充
        /// </summary>
        public string MapType
        { get { return maptype; } }

        /// <summary>
        /// {x:'center',y:'center'}     地图位置设置，默认只适应上下左右居中可配x，y，width，height，任意参数为空都将根据其他参数自适应
        /// </summary>
        public MapLocation MapLocation
        { get; set; }

        /// <summary>
        /// 'sum'   地图数值计算方式，默认为加和，可选为：'sum'（总数） | 'average'（均值）
        /// </summary>
        public MapValueCalculationType? MapValueCalculation
        { get; set; }

        /// <summary>
        /// 数据（详见series.data）
        /// </summary>
        public object Data
        { get; set; }

        /// <summary>
        /// 力导向图中节点的分类, 每一项有name和itemStyle两个属性
        /// </summary>
        public Categories[] Categories
        { get; set; }

        /// <summary>
        /// 力导向图的顶点数据, 每一项都有 name, value, category三个属性，分别表示节点的名称， 节点的值和节点的分类
        /// </summary>
        public Nodes[] Nodes
        { get; set; }

        /// <summary>
        /// 力导向图的边数据, 每一项都有 source, target, weight三个属性, source和target是顶点的索引值， 边的权重(weight)越大则两个顶点之间的联系越大(最后稳定之后的距离越小)
        /// </summary>
        public Links[] Links
        { get; set; }

        /// <summary>
        /// 10  顶点数据映射成圆半径后的最小半径
        /// </summary>
        public Number? MinRadius
        { get; set; }

        /// <summary>
        /// 20  顶点数据映射成圆半径后的最大半径
        /// </summary>
        public Number? MaxRadius
        { get; set; }

        /// <summary>
        /// 1   顶点的密度，影响布局时顶点运动的速度，值越大速度越慢
        /// </summary>
        public Number? Density
        { get; set; }

        /// <summary>
        /// 1   顶点之间的引力系数，影响到布局稳定之后的大小，值越大则稳定之后顶点之间的距离越小
        /// </summary>
        public Number? Attractiveness
        { get; set; }

        /// <summary>
        /// 是否开启滚轮缩放和拖拽漫游，默认为false（关闭），其他有效输入为true（开启）
        /// 如果需要 scale 或者move 请联系作者王文斌 由于不常用，暂不处理
        /// </summary>
        public bool? Roam { set; get; }

        /// <summary>
        /// 标注点属性
        /// </summary>
        public MarkPoint MarkPoint
        {
            set;
            get;
        }

        /// <summary>
        /// 标注线条属性
        /// </summary>
        public MarkLine MarkLine
        {
            set;
            get;
        }

        /// <summary>
        /// 以数组形式返回对象，方便单个对象使用
        /// 请根据情况使用
        /// </summary>
        /// <returns></returns>
        public Series[] ToArray()
        {
            Series[] arr = new Series[1];
            arr[0] = this;
            return arr;
        }
    }
}
