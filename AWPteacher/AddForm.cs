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
    public partial class AddForm : Form
    {
        private Form1 parentForm;

        private TextBox[] textBoxes;

        public void DrawElements()
        {
            string[] fields = GUI.Model.CurrentModel.GUIModel.FieldHeadersForAdd;
            textBoxes = new TextBox[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = fields[i];
                textBoxes[i].Location = new System.Drawing.Point(13, 13 + (i * 20));
                textBoxes[i].Name = "textBox" + i;
                textBoxes[i].Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(textBoxes[i]);
            }
        }

        public AddForm(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.Model.CurrentModel.GUIModel.AddInList(textBoxes);
            this.Close();
            parentForm.DataGridViewDraw();
        }
    }
}
