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
        public void DrawElements(string[] fields)
        {
            TextBox[] textBoxes = new TextBox[fields.Length];
            
            // 
            // textBox1
            // 
            for (int i = 0; i < fields.Length; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = fields[i];
                textBoxes[i].Location = new System.Drawing.Point(13, 13 + (i * 20));
                textBoxes[i].Name = "textBox" + i;
                textBoxes[i].Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(textBoxes[i]);
            }

            

            /*
            textBoxes[0].Show();
            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[1];
            buttons[0] = new System.Windows.Forms.Button();
            //
            //button 1
            //
            buttons[0].Location = new System.Drawing.Point(307, 121);
            buttons[0].Name = "button1";
            buttons[0].Size = new System.Drawing.Size(75, 23);
            buttons[0].TabIndex = 0;
            buttons[0].Text = "Добавить";
            addForm.Controls.Add(buttons[0]);*/
        }

        public AddForm()
        {
            InitializeComponent();
        }
    }
}
