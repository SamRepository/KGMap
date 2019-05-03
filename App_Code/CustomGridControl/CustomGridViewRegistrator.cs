using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid;

namespace S133193Example
{
    class CustomGridViewRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get
            {
                return "CustomGridView";
            }
        }

        public override DevExpress.XtraGrid.Views.Base.BaseView CreateView(DevExpress.XtraGrid.GridControl grid)
        {
            return new CustomGridView(grid as GridControl);
        }
    }
}
