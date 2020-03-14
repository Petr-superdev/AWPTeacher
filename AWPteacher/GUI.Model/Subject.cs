using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Subject :  IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = { "Урок" };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID","Урок" };
        public  int[] FieldHeadersWidthForGrid { get; set; } = {50,100 };
    }
}
