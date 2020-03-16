using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWPteacher.Model
{
    public abstract class Model
    {
        public abstract void SaveListInTxt();
        public abstract void LoadListFromTxt();
        
    }
}
