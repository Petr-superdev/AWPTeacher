using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Mark :  IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = { "Оценка" };
        public  string[] FieldHeadersForGrid { get; set; } = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
        "","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",};
        public  int[] FieldHeadersWidthForGrid { get; set; } = {15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15,
        15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,};

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Mark.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();

                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Mark.List[i].Value;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {
            string value = textBoxes[0].Text;
            byte byteValue;
            if (byte.TryParse(value, out byteValue))
            {
                var mark_ = new AWPteacher.Model.Mark(byteValue);
                AWPteacher.Model.Mark.List.Add(mark_);
            }
        }
    }
}
