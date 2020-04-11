using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AWPteacher.GUI.Model;

namespace AWPteacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DataGridViewDraw()
        {
            ColumnsDraw();
            CellsDraw();
        }

        public void ColumnsDraw()
        {
            string[] columns = CurrentModel.GUIModel.FieldHeadersForGrid;
            int[] columnWides = CurrentModel.GUIModel.FieldHeadersWidthForGrid;

            dataGridView1.Columns.Clear();
            DataGridViewColumn[] dgvc = new DataGridViewColumn[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                dgvc[i] = new DataGridViewTextBoxColumn();
                dgvc[i].HeaderText = columns[i];
                dgvc[i].Name = "dgvc" + i;
                dgvc[i].Width = columnWides[i];
            }
            dataGridView1.Columns.AddRange(dgvc);
        }

        public void CellsDraw()
        {
            GUI.Model.CurrentModel.GUIModel.CellsDraw(dataGridView1);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Class(), new Model.Class());
            DataGridViewDraw();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Student(), new Model.Student());
            DataGridViewDraw();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Subject(), new Model.Subject());
            DataGridViewDraw();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Mark(), new Model.Mark());
            DataGridViewDraw();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Teacher(), new Model.Teacher());
            DataGridViewDraw();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CurrentModel.Set(new Lesson(), new Model.Lesson());
            DataGridViewDraw();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
            addForm.DrawElements();      
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Model model = new Model.Class();
            model.SaveListInTxt();
            model = new Model.Lesson();
            model.SaveListInTxt();
            model = new Model.Mark();
            model.SaveListInTxt();
            model = new Model.Student();
            model.SaveListInTxt();
            model = new Model.Subject();
            model.SaveListInTxt();
            model = new Model.Teacher();
            model.SaveListInTxt();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Model model1 = new Model.Class();
            model1.LoadListFromTxt();
            Model.Model model2 = new Model.Lesson();
            model2.LoadListFromTxt();
            Model.Model model3 = new Model.Mark();
            model3.LoadListFromTxt();
            Model.Model model4 = new Model.Student();
            model4.LoadListFromTxt();
            Model.Model model5 = new Model.Subject();
            model5.LoadListFromTxt();
            Model.Model model6 = new Model.Teacher();
            model6.LoadListFromTxt();
            DataGridViewDraw();
            
        }
        /*
        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
        ToolStripMenuItem toolStripItem2 = new ToolStripMenuItem();
        ToolStripMenuItem toolStripItem3 = new ToolStripMenuItem();
        ToolStripMenuItem toolStripItem4 = new ToolStripMenuItem();

        //Создание контекстного меню
        private void AddContextMenu()
        {
            toolStripItem1.Text = "Уроки";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);

            toolStripItem2.Text = "Ученики";
            toolStripItem2.Click += new EventHandler(toolStripItem2_Click);

            toolStripItem3.Text = "Учебные предметы";
            toolStripItem3.Click += new EventHandler(toolStripItem3_Click);

            toolStripItem4.Text = "Учителя";
            toolStripItem4.Click += new EventHandler(toolStripItem4_Click);

            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ContextMenuStrip = strip;
                column.ContextMenuStrip.Items.Add(toolStripItem1);
                column.ContextMenuStrip.Items.Add(toolStripItem2);
                column.ContextMenuStrip.Items.Add(toolStripItem3);
                column.ContextMenuStrip.Items.Add(toolStripItem4);
            }
        }

        private void toolStripItem1_Click(object sender, EventArgs args)
        {
            dataGridView1.Rows[mouseLocation.RowIndex]
                .Cells[mouseLocation.ColumnIndex].Style.BackColor
                = Color.Red;
        }
        private void toolStripItem2_Click(object sender, EventArgs args)
        {
        }
        private void toolStripItem3_Click(object sender, EventArgs args)
        {
        }
        private void toolStripItem4_Click(object sender, EventArgs args)
        {
        }*/

        private DataGridViewCellEventArgs mouseLocation;
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
            GUI.Model.CurrentModel.GUIModel.AddContextMenu(dataGridView1);
        }
    }
}
