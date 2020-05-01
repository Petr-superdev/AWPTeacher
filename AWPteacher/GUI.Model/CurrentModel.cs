using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWPteacher.GUI.Model
{
    static class CurrentModel
    {
        static public IModel GUIModel { get; set; } = new Class();
        static public AWPteacher.Model.Model Model { get; set; } = new AWPteacher.Model.Class();
        static public AWPteacher.Model.Needs ModelNeeds { get; set; } = new AWPteacher.Model.StudentNeeds.StudentNeeds();
        static public void Set(IModel GUIModel, AWPteacher.Model.Model Model, AWPteacher.Model.Needs need )
        {
            CurrentModel.GUIModel = GUIModel;
            CurrentModel.Model = Model;
            CurrentModel.ModelNeeds = need;
        }
    }
}
