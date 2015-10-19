/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 标志图形类型
 * */
using System;

namespace wwb.ECharts.Enums
{
    /// <summary>
    /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
    /// 'circle' | 'rectangle' | 'triangle' | 'diamond' |
    /// 'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond' 
    /// 另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用
    /// </summary>
    public enum SymbolType
    {
        Circle,
        Rectangle,
        Triangle,
        Diamond,
        EmptyCircle,
        EmptyRectangle,
        EmptyTriangle,
        EmptyDiamond,
        Heart,  //地图追加
        Droplet,
        Pin,
        Arrow,
        Star
    }
}
