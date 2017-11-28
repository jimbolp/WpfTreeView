using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Folder Expanded
        /// <summary>
        /// When a Folder expands, find the sub folders/files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            //#region Initial Checks
            //TreeViewItem item = (TreeViewItem)sender;

            //if(item.Items.Count != 1 && item.Items[0] != null)
            //{
            //    return;
            //}
            //item.Items.Clear();

            //string fullPath = (string)item.Tag;
            //#endregion

            
        }
        #endregion

        
    }
}
