using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Student : IModel
    {
        public  string[] TextBoxFieldHeadersForAdd { get; set; } = { "ФИО ученика/цы" };
        public string[] ComboBoxFieldHeadersForAdd { get; set; } = { "Класс" };
        public AWPteacher.Model.Model[] ComboBoxFieldModelsForAdd { get; set; } = { new AWPteacher.Model.ClassGroup() };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID" , "ФИО" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50,150};
        public List<ToolStripMenuItem> ToolStripMenuItems { get; set; } = new List<ToolStripMenuItem>();
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
            ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
            toolStripItem1.Text = "Класс";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            ToolStripMenuItem toolStripItem2 = new ToolStripMenuItem();
            toolStripItem2.Text = "Предметы";
            toolStripItem2.Click += new EventHandler(toolStripItem2_Click);

            ToolStripMenuItem toolStripItem3 = new ToolStripMenuItem();
            toolStripItem3.Text = "Оценки";
            toolStripItem3.Click += new EventHandler(toolStripItem3_Click);

            ToolStripMenuItem toolStripItem4 = new ToolStripMenuItem();
            toolStripItem4.Text = "Учителя";
            toolStripItem4.Click += new EventHandler(toolStripItem4_Click);

            ToolStripMenuItem toolStripItem5 = new ToolStripMenuItem();
            toolStripItem5.Text = "Уроки";
            toolStripItem5.Click += new EventHandler(toolStripItem4_Click);


            ToolStripMenuItems.Add(toolStripItem1);
            ToolStripMenuItems.Add(toolStripItem2);
            ToolStripMenuItems.Add(toolStripItem3);
            ToolStripMenuItems.Add(toolStripItem4); 
            ToolStripMenuItems.Add(toolStripItem5);

            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.ContextMenuStrip = strip;
                foreach (ToolStripMenuItem toolStripItem in ToolStripMenuItems)
                {
                    column.ContextMenuStrip.Items.Add(toolStripItem);
                }
            }
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
        private void toolStripItem5_Click(object sender, EventArgs args)
        {
        }
    }
}

