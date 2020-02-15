using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.GUI.Model
{
    class Class : IModel
    {
        public string[] FieldHeadersForAdd { get; set; } = { "Класс" };
        public string[] FieldHeadersForGrid { get; set; } = { "ID", "Класс" };
        public int[] FieldHeadersWidthForGrid { get; set; } = { 50, 100 };
    }
}
