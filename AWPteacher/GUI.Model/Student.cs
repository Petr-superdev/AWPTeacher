using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Student : IModel
    {
        public  string[] FieldHeadersForAdd { get; set; } = {"ФИО ученика/цы" };
        public  string[] FieldHeadersForGrid { get; set; } = { "ID","ФИО"};
        public  int[] FieldHeadersWidthForGrid { get; set; } = { 50,150};
    }
}
