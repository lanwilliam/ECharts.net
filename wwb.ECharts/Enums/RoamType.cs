/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 滚轮设置
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Enums
{
    /// <summary>
    /// 是否开启滚轮缩放和拖拽漫游，默认为false（关闭），其他有效输入为true（开启），'scale'（仅开启滚轮缩放），'move'（仅开启拖拽漫游）
    /// </summary>
    public enum RoamType
    {
        False,True,Scale,Move
    }
}
