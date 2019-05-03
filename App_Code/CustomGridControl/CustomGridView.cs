using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Tab;


namespace S133193Example
{
    [System.ComponentModel.DesignerCategory("")]
    public class CustomGridView : GridView
    {
        public CustomGridView() { }
        public CustomGridView(GridControl grid) : base(grid) { }
        public delegate void DrawTabImageHandler(object sender, DrawTabImageEventArgs e);
        public event DrawTabImageHandler GetTabImage;
        public virtual void OnDrawTabImage(DrawTabImageEventArgs e)
        {
            if (GetTabImage != null)
            {
                GetTabImage(this, e);
            }

        }

        protected override void PopulateTabMasterData(DevExpress.XtraGrid.Tab.ViewTab tabControl, int rowHandle)
        {
            List<CustomViewTabPage> pages = new List<CustomViewTabPage>();
            base.PopulateTabMasterData(tabControl, rowHandle);
            foreach (ViewTabPage page in tabControl.Pages)
            {
                CustomViewTabPage cPage = new CustomViewTabPage(tabControl);
                cPage.DetailInfo = page.DetailInfo;
                cPage.Tag = page.Tag;
                cPage.Text = page.Text;
                cPage.Image = GetPageImage(rowHandle,(int)cPage.Tag);
                pages.Add(cPage);
            }
            tabControl.Pages.Clear();
            foreach (CustomViewTabPage cPage in pages)
                tabControl.Pages.Add(cPage);
        }

        private Image GetPageImage(int rowHandle,int relationIndex)
        {
            DrawTabImageEventArgs args = new DrawTabImageEventArgs(rowHandle, null,relationIndex);
            OnDrawTabImage(args);
                return args.Image;
        }

        protected override string ViewName
        {
            get
            {
                return "CustomGridView";
            }
        }



    }
}
