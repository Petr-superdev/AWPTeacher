using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.GUI.Model
{
    interface IModel
    {
        string[] FieldHeadersForAdd { get; set; }
        string[] FieldHeadersForGrid { get; set; } 
        int[] FieldHeadersWidthForGrid { get; set; } 
    }
        
}
