using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Student : IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = {"ФИО ученика/цы" };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID","ФИО"};
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50,150};
        public List<ToolStripMenuItem> ToolStripMenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Student.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();

                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Student.List[i].Id;
                dataGridView.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Student.List[i].Name;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {
            string name = textBoxes[0].Text;

            var student_ = new AWPteacher.Model.Student(name);

            AWPteacher.Model.Student.List.Add(student_);
        }

        public void AddContextMenu(DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }
    }
}
