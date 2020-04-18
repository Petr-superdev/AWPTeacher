using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Subject :  IModel
    {
        public  string[] TextBoxFieldHeadersForAdd { get; set; } = { "Урок" };
        public string[] ComboBoxFieldHeadersForAdd { get; set; }
        public  string[] FieldHeadersForGrid { get; set; } = { "ID","Урок" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = {50,100 };
        public List<ToolStripMenuItem> ToolStripMenuItems { get; set; } = new List<ToolStripMenuItem>();
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

        public void AddContextMenu(DataGridView dataGridView)
        {
            ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
            toolStripItem1.Text = "Классы";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            

            

            ToolStripMenuItem toolStripItem4 = new ToolStripMenuItem();
            toolStripItem4.Text = "Учителя";
            toolStripItem4.Click += new EventHandler(toolStripItem4_Click);

            


            ToolStripMenuItems.Add(toolStripItem1);
            
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
        private void toolStripItem5_Click(object sender, EventArgs args)
        {
        }
    }
}
