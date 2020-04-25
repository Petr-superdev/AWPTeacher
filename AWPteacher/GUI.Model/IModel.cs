using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    interface IModel
    {
        string[] TextBoxFieldHeadersForAdd { get; set; }
        string[] ComboBoxFieldHeadersForAdd { get; set; }
        AWPteacher.Model.Model[] ComboBoxFieldModelsForAdd { get; set; }

        string[] FieldHeadersForGrid { get; set; } 
        int[] FieldHeadersWidthForGrid { get; set; }
        List<ToolStripMenuItem> ToolStripMenuItems { get; set; }

        void CellsDraw(DataGridView dataGridView);

        void AddInList(TextBox[] textBoxes);

        void AddContextMenu(DataGridView dataGridView);
    }
}
