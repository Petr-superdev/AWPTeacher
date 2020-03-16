using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    interface IModel
    {
        string[] FieldHeadersForAdd { get; set; } 
        string[] FieldHeadersForGrid { get; set; } 
        int[] FieldHeadersWidthForGrid { get; set; }

        void CellsDraw(DataGridView dataGridView);

        void AddInList(TextBox[] textBoxes);
        
    }
}
