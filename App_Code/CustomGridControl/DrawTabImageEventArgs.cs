using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace S133193Example
{
   public class DrawTabImageEventArgs:EventArgs
    {
        
       public int RowHandle { get; set; }
       public Image Image { get; set; }
       public int RelationIndex { get; set; }
        
        public DrawTabImageEventArgs(int rowHandle, Image image,int relationIndex)
        {
            RowHandle = rowHandle;
            Image = image;
            RelationIndex = relationIndex;
        }
    }
}
