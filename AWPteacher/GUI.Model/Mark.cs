using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Mark :  IModel
    {
        public  string[] TextBoxFieldHeadersForAdd { get; set; } = { "Оценка" };
        public string[] ComboBoxFieldHeadersForAdd { get; set; }
        public AWPteacher.Model.Model[] ComboBoxFieldModelsForAdd { get; set; }
        public  string[] FieldHeadersForGrid { get; set; } = {""};
        public  int[] FieldHeadersWidthForGrid { get; set; } = {15};
        public List<ToolStripMenuItem> ToolStripMenuItems { get; set; } = new List<ToolStripMenuItem>();
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

        public void AddContextMenu(DataGridView dataGridView)
        {
            ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
            toolStripItem1.Text = "Учитель";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            

            ToolStripMenuItems.Add(toolStripItem1);

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
    }
}

