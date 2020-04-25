using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Lesson : IModel
    {
        public  string[] TextBoxFieldHeadersForAdd { get; set; } = { "Домашнее задание" };
        public string[] ComboBoxFieldHeadersForAdd { get; set; }
        public AWPteacher.Model.Model[] ComboBoxFieldModelsForAdd { get; set; }
        public  string[] FieldHeadersForGrid { get; set; } = {"ID", "Домашнее задание" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50, 200 };
        public List<ToolStripMenuItem> ToolStripMenuItems { get; set; } = new List<ToolStripMenuItem>();
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
            ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
            toolStripItem1.Text = "Классы";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            ToolStripMenuItem toolStripItem2 = new ToolStripMenuItem();
            toolStripItem2.Text = "Ученики";
            toolStripItem2.Click += new EventHandler(toolStripItem2_Click);

            

            ToolStripMenuItem toolStripItem4 = new ToolStripMenuItem();
            toolStripItem4.Text = "Учителя";
            toolStripItem4.Click += new EventHandler(toolStripItem4_Click);

            ToolStripMenuItems.Add(toolStripItem1);
            ToolStripMenuItems.Add(toolStripItem2);
            ToolStripMenuItems.Add(toolStripItem4);

            ContextMenuStrip strip = new ContextMenuStrip();

            dataGridView.ContextMenuStrip = strip;

            //foreach (DataGridViewColumn column in dataGridView.Columns)
            //{
                //column.ContextMenuStrip = strip;
                foreach (ToolStripMenuItem toolStripItem in ToolStripMenuItems)
                {
                    dataGridView.ContextMenuStrip.Items.Add(toolStripItem);
                }
            //}
        }
        private void toolStripItem1_Click(object sender, EventArgs args)
        {
            /*dataGridView1.Rows[mouseLocation.RowIndex]
                .Cells[mouseLocation.ColumnIndex].Style.BackColor
                = Color.Red;*/
        }
        private void toolStripItem2_Click(object sender, EventArgs args)
        {
        }
        private void toolStripItem3_Click(object sender, EventArgs args)
        {
        }
        private void toolStripItem4_Click(object sender, EventArgs args)
        {
        }
    }
}
