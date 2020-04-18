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
        private ComboBox[] comboBoxes;
        public void DrawElements()
        {
            string[] textBoxfields = GUI.Model.CurrentModel.GUIModel.TextBoxFieldHeadersForAdd;
            textBoxes = new TextBox[textBoxfields.Length];
            int next_position=0;
            for (int i = 0; i < textBoxfields.Length; i++, next_position++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = textBoxfields[i];
                textBoxes[i].Location = new System.Drawing.Point(13, 13 + (next_position * 20));
                textBoxes[i].Name = "textBox" + i;
                textBoxes[i].Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(textBoxes[i]);

                next_position = i;
            }
            string[] comboBoxfields = GUI.Model.CurrentModel.GUIModel.ComboBoxFieldHeadersForAdd;
            if (comboBoxfields != null)
            {
                comboBoxes = new ComboBox[comboBoxfields.Length];
                for (int i = 0; i < comboBoxfields.Length; i++, next_position++)
                {
                    comboBoxes[i] = new ComboBox();
                    comboBoxes[i].Text = comboBoxfields[i];
                    comboBoxes[i].Location = new System.Drawing.Point(13, 13 + (next_position * 20));
                    comboBoxes[i].Name = "comboBox" + i;
                    comboBoxes[i].Size = new System.Drawing.Size(100, 20);
                    this.Controls.Add(comboBoxes[i]);
                }
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
