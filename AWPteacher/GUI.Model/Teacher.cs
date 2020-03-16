using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Teacher :  IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = {"ФИО учителя" };
        public  string[] FieldHeadersForGrid { get; set; } = {"ID","ФИО" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = {50,150 };

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Teacher.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();
                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Teacher.List[i].Id;
                dataGridView.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Teacher.List[i].Name;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {
            string name = textBoxes[0].Text;
            var teacher_ = new AWPteacher.Model.Teacher(name);
            AWPteacher.Model.Teacher.List.Add(teacher_);
        }
    }
}
