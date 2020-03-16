using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Subject :  IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = { "Урок" };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID","Урок" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = {50,100 };

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Subject.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Subject.List[i].Id;
                dataGridView.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Subject.List[i].Name;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {

            string name = textBoxes[0].Text;

            var subject_ = new AWPteacher.Model.Subject(name);
            AWPteacher.Model.Subject.List.Add(subject_);
        }
    }
}
