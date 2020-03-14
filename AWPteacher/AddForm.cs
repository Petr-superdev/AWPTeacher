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
            if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Class)
            {
                AWPteacher.Model.Class class_ = (AWPteacher.Model.Class)GUI.Model.CurrentModel.Model;

                string name = textBoxes[0].Text;

                class_ = new AWPteacher.Model.Class(name);

                AWPteacher.Model.Class.List.Add(class_);

            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Lesson)
            {

                AWPteacher.Model.Lesson lesson_ = (AWPteacher.Model.Lesson)GUI.Model.CurrentModel.Model;

                string hw = textBoxes[0].Text;

                lesson_ = new AWPteacher.Model.Lesson(hw);

            }
            ////
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Mark)
            {

                AWPteacher.Model.Mark mark_ = (AWPteacher.Model.Mark)GUI.Model.CurrentModel.Model;

                string value = textBoxes[0].Text;

                mark_ = new AWPteacher.Model.Mark(Convert.ToByte(value));

            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Subject)
            {

                AWPteacher.Model.Subject subject_ = (AWPteacher.Model.Subject)GUI.Model.CurrentModel.Model;

                string name = textBoxes[0].Text;

                subject_ = new AWPteacher.Model.Subject(name);

            }
            else if (GUI.Model.CurrentModel.Model is AWPteacher.Model.Teacher)
            {

                AWPteacher.Model.Teacher teacher_ = (AWPteacher.Model.Teacher)GUI.Model.CurrentModel.Model;

                string name = textBoxes[0].Text;

                teacher_ = new AWPteacher.Model.Teacher(name);

            }
            this.Close();
            parentForm.DataGridViewDraw();
        }
    }
}
