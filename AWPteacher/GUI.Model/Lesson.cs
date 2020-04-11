using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Lesson : IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = { "Домашнее задание" };
        public  string[] FieldHeadersForGrid { get; set; } = {"ID", "Домашнее задание" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50, 200 };
        public List<ToolStripMenuItem> ToolStripMenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CellsDraw(DataGridView dataGridView)
        {
            for (int i = 0; i < AWPteacher.Model.Lesson.List.Count; i++)
            {
                int rowNumber = dataGridView.Rows.Add();

                dataGridView.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Lesson.List[i].Id;
                dataGridView.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Lesson.List[i].HomeWork;
            }
        }

        public void AddInList(TextBox[] textBoxes)
        {
            string homeWork = textBoxes[0].Text;

            var lesson_ = new AWPteacher.Model.Lesson(homeWork);

            AWPteacher.Model.Lesson.List.Add(lesson_);
        }

        public void AddContextMenu(DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }
    }
}
