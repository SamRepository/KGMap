using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;

namespace S133193Example
{
    [System.ComponentModel.DesignerCategory("")]
    class CustomGridControl :GridControl
    {
        protected override DevExpress.XtraGrid.Views.Base.BaseView CreateDefaultView()
        {
            return (CreateView("CustomGridView"));
        }
        protected override void RegisterAvailableViewsCore(DevExpress.XtraGrid.Registrator.InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridViewRegistrator());
        }
    }
}
