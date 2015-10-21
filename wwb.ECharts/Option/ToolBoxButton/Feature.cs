/**
 * 作者：王文斌
 * 做成日期：2015-9-15
 * 工具箱按钮设定
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wwb.ECharts.Option.ToolBoxButton
{
    /// <summary>
    /// 启用功能，目前支持feature见下
    /// </summary>
    public class Feature
    {
        private Mark mark;
        /// <summary>
        /// 辅助线按钮
        /// </summary>
        public Mark Mark
        {
            set { this.mark = value; }
            get
            {

                if (this.mark == null)
                    this.mark = new Mark();
                return this.mark;
            }
        }

        private DataZoom dataZoom;


        /// <summary>
        /// 数据缩放按钮
        /// </summary>
        public DataZoom DataZoom
        {
            set { this.dataZoom = value; }
            get
            {
                if (this.dataZoom == null)
                    this.dataZoom = new DataZoom();
                return this.dataZoom;
            }
        }


        private Restore restore;

        /// <summary>
        /// 还原按钮
        /// </summary>
        public Restore Restore
        {
            set { this.restore = value; }
            get
            {
                if (this.restore == null)
                    this.restore = new Restore();
                return this.restore;
            }
        }

        private SaveAsImage saveAsImage;
        /// <summary>
        /// 保存图片按钮
        /// </summary>
        public SaveAsImage SaveAsImage
        {
            set { this.saveAsImage = value; }
            get
            {
                if (this.saveAsImage == null)
                    this.saveAsImage = new SaveAsImage();
                return this.saveAsImage;
            }
        }


        private MagicType magicType;
        /// <summary>
        /// 图表类型变换，请先自行实验或对照EchartsAPI，确认支持哪些
        /// bar，line应该没问题其他自行测试，需要满足的数据条件不同
        /// </summary>
        public MagicType MagicType
        {
            set { this.magicType = value; }
            get
            {
                if (this.magicType == null)
                    this.magicType = new MagicType();
                return this.magicType;
            }
        }
    }
}
