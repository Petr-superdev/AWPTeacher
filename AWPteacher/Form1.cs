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
            if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Class)
            {
                for (int i = 0; i < AWPteacher.Model.Class.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Class.List[i].Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Class.List[i].Name;
                }
            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Lesson)
            {
                for (int i = 0; i < AWPteacher.Model.Lesson.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Lesson.List[i].Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = AWPteacher.Model.Lesson.List[i].HomeWork;
                }
            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Mark)
            {
                for (int i = 0; i < AWPteacher.Model.Mark.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Mark.List[i].Value;
                }
            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Student)
            {
                for (int i = 0; i < AWPteacher.Model.Student.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Student.List[i].Name;
                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Student.List[i].Id;
                }
            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Subject)
            {
                for (int i = 0; i < AWPteacher.Model.Subject.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Subject.List[i].Name;
                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Subject.List[i].Id;
                }
            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Teacher)
            {
                for (int i = 0; i < AWPteacher.Model.Teacher.List.Count; i++)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Teacher.List[i].Name;
                    dataGridView1.Rows[rowNumber].Cells[0].Value = AWPteacher.Model.Teacher.List[i].Id;
                }
            }
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
    }
}
