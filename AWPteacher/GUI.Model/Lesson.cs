using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWPteacher.GUI.Model
{
    class Lesson : IModel
    {
        public string[] FieldHeadersForAdd { get; set; } = { "Домашнее задание" };
        public string[] FieldHeadersForGrid { get; set; } = {"ID", "Домашнее задание" };
        public int[] FieldHeadersWidthForGrid { get; set; } = { 50, 200 };
    }
}
