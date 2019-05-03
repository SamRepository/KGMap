using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Tab;
using DevExpress.XtraTab;
using System.Drawing;

namespace S133193Example
{
    public class CustomViewTabPage : ViewTabPage, IXtraTabPage
    {

        public CustomViewTabPage(ViewTab tabControl) : base(tabControl) { }
        public Image Image { get; set; }
        Image IXtraTabPage.Image { get { return Image; } }
    } 
}
