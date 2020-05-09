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
            string[] textBoxFields = GUI.Model.CurrentModel.GUIModel.TextBoxFieldHeadersForAdd;
            textBoxes = new TextBox[textBoxFields.Length];

            int next_position = 0;
            for (int i = 0; i < textBoxFields.Length; i++, next_position++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = textBoxFields[i];
                textBoxes[i].Location = new System.Drawing.Point(13, 13 + (next_position * 20));
                textBoxes[i].Name = "textBox" + i;
                textBoxes[i].Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(textBoxes[i]);
            }
            
            if (GUI.Model.CurrentModel.GUIModel.ComboBoxFieldHeadersForAdd != null)
            {
                string[] comboBoxFields = GUI.Model.CurrentModel.GUIModel.ComboBoxFieldHeadersForAdd;

                comboBoxes = new ComboBox[comboBoxFields.Length];
                for (int i = 0; i < comboBoxFields.Length; i++, next_position++)
                {
                    comboBoxes[i] = new ComboBox();
                    comboBoxes[i].Text = comboBoxFields[i];
                    comboBoxes[i].Location = new System.Drawing.Point(13, 13 + (next_position * 20));
                    comboBoxes[i].Name = "comboBox" + i;
                    comboBoxes[i].Size = new System.Drawing.Size(100, 20);

                    var comboBoxModels = GUI.Model.CurrentModel.GUIModel.ComboBoxFieldModelsForAdd;
                    if (comboBoxModels != null)
                    {
                        foreach (var model in comboBoxModels)
                        {
                            List<AWPteacher.Model.Model> list = model.GetList();
                            foreach (var item in list)
                            {
                                comboBoxes[i].Items.Add(item.GetInfoForComboBox());
                            }
                        }
                    }

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
