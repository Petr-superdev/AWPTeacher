using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Class : IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = { "Класс" };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID", "Класс" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50, 100 };

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Class.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();

                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Class.List[i].Id;
                dataGridView.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Class.List[i].Name;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {
            string name = textBoxes[0].Text;

            var class_ = new AWPteacher.Model.Class(name);

            AWPteacher.Model.Class.List.Add(class_);
        }

        
    }
}
