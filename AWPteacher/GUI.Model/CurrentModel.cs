using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.GUI.Model
{
    static class CurrentModel
    {
        static public IModel GUIModel { get; set; }
        static public AWPteacher.Model.Model Model { get; set; }

        static public void Set(IModel GUIModel, AWPteacher.Model.Model Model)
        {
            CurrentModel.GUIModel = GUIModel;
            CurrentModel.Model = Model;
        }
    }
}
