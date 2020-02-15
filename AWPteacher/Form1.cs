using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher
{
    public partial class Form1 : Form
    {
        GUI.Model.IModel model;
        string type;

        public Form1()
        {
            InitializeComponent();
        }

        private void ColumnsDrawings(string[] columns,int[] columnWides)
        {
            dataGridView1.Columns.Clear();
            DataGridViewColumn[] dgvc = new DataGridViewColumn[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                dgvc[i] = new DataGridViewTextBoxColumn();
                dgvc[i].HeaderText = columns[i];
                dgvc[i].Name = "dgvc"+i;
                dgvc[i].Width = columnWides[i];
            }
            dataGridView1.Columns.AddRange(dgvc);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Class();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type="class";
            //model.ShowAll(ref dataGridView1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Students();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type = "students";
            //model.ShowAll(ref dataGridView1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Subjects();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type = "subjects";
            //model.ShowAll(ref dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Marks();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type = "marks";
            //model.ShowAll(ref dataGridView1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Teachers();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type = "teachers";
            //model.ShowAll(ref dataGridView1);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            model = new GUI.Model.Lesson();
            ColumnsDrawings(model.FieldHeadersForGrid, model.FieldHeadersWidthForGrid);
            type = "lesson";
            //model.ShowAll(ref dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            AddForm addForm = new AddForm();
            switch (type)
            {
                case "class":
                    model = new GUI.Model.Class();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                case "students":
                    model = new GUI.Model.Students();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                case "subjects":
                    model = new GUI.Model.Subjects();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                case "marks":
                    model = new GUI.Model.Marks();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                case "teachers":
                    model = new GUI.Model.Teachers();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                case "lesson":
                    model = new GUI.Model.Lesson();
                    addForm.Show();
                    addForm.DrawElements(model.FieldHeadersForAdd);
                    break;
                default:
                    break;
            }
            //model.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
