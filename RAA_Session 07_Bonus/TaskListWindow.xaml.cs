using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.UI;

namespace RAA_Session_07_Bonus
{
    /// <summary>
    /// Interaction logic for TaskListWindow.xaml
    /// </summary>
    public partial class TaskListWindow : Window
    {
        public TaskListWindow()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            lbxTasks.Items.Add(tbxItem.Text);
            tbxItem.Text = "";
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            TaskDialog.Show("test", "Clicked up button");
        }

        private void btnDn_Click(object sender, RoutedEventArgs e)
        {
            TaskDialog.Show("test", "Clicked down button");
        }

        private void lbxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskDialog.Show("test", "I selected an item");
        }
    }
}
