#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace RAA_Session_07_Bonus
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            TaskListWindow curForm = new TaskListWindow();

            curForm.Width = 500;
            curForm.Height = 700;

            curForm.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            curForm.Topmost = true;

            curForm.ShowDialog();

            return Result.Succeeded;
        }
    }
}
