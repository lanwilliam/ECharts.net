using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    public class Toolbox
    {
        /// <summary>
        /// 是否显示toolbox 默认true
        /// </summary>
        public bool show=true;

        /// <summary>
        /// 辅助线开启按钮 默认开启
        /// </summary>
        public bool mark = true;

        /// <summary>
        /// 数据视图 默认false
        /// </summary>
        public bool dataView = false;

        /// <summary>
        /// 还原 默认true
        /// </summary>
        public bool restore = true;

        /// <summary>
        /// 另存为图片
        /// </summary>
        public bool saveAsImage = true;

        string format = @"
    {
        show : {0},
        feature : {
            mark : {show: {1} },
            dataView : {show: {2}, readOnly: false},
            restore : {show: {3}},
            saveAsImage : {show: {4}}
        }
    }
";

        public string GetJSONString()
        {
            return Util.Format(format, show, mark, dataView, restore, saveAsImage);
        }
    }
}
