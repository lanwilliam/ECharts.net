using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwb.map
{
    /// <summary>
    /// 标题，每个图表最多仅有一个标题控件，每个标题控件可设主副标题。
    /// </summary>
    public class Title
    {
        public Title()
        {

        }
        public Title(string text,string color)
        {
            Text = text;
            Color = color;
        }

        private string text = "Title";

        /// <summary>
        /// 主标题文本
        /// </summary>
        public string Text
        {
            get{ return this.text; }
            set { this.text = value; }
        }

        private string color = "#000";

        /// <summary>
        /// 标题颜色 #000
        /// </summary>
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        string format = @"
    {
        text : '{0}',
        textStyle: {
            color: '{1}'
        }
    }
";
        /// <summary>
        /// 获取格式化JSON文本
        /// </summary>
        /// <returns></returns>
        public string GetTitleString()
        {
            string rtn = format.Replace("{0}", Text);
            rtn = rtn.Replace("{1}", Color);
            return rtn;
        }

    }
}
