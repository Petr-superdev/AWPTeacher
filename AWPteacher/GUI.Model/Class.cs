using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Class : IModel
    {
        public  string[] TextBoxFieldHeadersForAdd { get; set; } = { "Класс" };
        public string[] ComboBoxFieldHeadersForAdd { get; set; }
        public  string[] FieldHeadersForGrid { get; set; } = { "ID", "Класс" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50, 100 };
        public List<ToolStripMenuItem> ToolStripMenuItems { get; set; } = new List<ToolStripMenuItem>();
        

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

        public void AddContextMenu(DataGridView dataGridView)
        {
            ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
            toolStripItem1.Text = "Уроки";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            ToolStripMenuItem toolStripItem2 = new ToolStripMenuItem();
            toolStripItem2.Text = "Ученики";
            toolStripItem2.Click += new EventHandler(toolStripItem2_Click);

            ToolStripMenuItem toolStripItem3 = new ToolStripMenuItem();
            toolStripItem3.Text = "Учебные предметы";
            toolStripItem3.Click += new EventHandler(toolStripItem3_Click);

            ToolStripMenuItem toolStripItem4 = new ToolStripMenuItem();
            toolStripItem4.Text = "Учителя";
            toolStripItem4.Click += new EventHandler(toolStripItem4_Click);

            ToolStripMenuItems.Add(toolStripItem1);
            ToolStripMenuItems.Add(toolStripItem2);
            ToolStripMenuItems.Add(toolStripItem3);
            ToolStripMenuItems.Add(toolStripItem4);

            ContextMenuStrip strip = new ContextMenuStrip();
            dataGridView.ContextMenuStrip = strip;
            
                
                foreach (ToolStripMenuItem toolStripItem in ToolStripMenuItems)
                {
                    dataGridView.ContextMenuStrip.Items.Add(toolStripItem);
                
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
    }
}
