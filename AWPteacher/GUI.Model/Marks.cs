using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Marks : IModel
    {
        public string[] FieldHeadersForAdd { get; set; } = { "Оценка" };
        public string[] FieldHeadersForGrid { get; set; } = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
        "","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",};
        public int[] FieldHeadersWidthForGrid { get; set; } = {15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15,
        15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,};

    }
}
