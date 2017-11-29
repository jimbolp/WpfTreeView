using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTreeView
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectoryItemViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// The type of the directory item. Either Drive, folder or file
        /// </summary>
        public DirectoryItemType Type { get; set; }
        
        /// <summary>
        /// The full path to the file/folder
        /// </summary>
        public string FullPath { get; set; }
        
        /// <summary>
        /// The name of this directory item
        /// </summary>
        public string Name { get { return Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }

        /// <summary>
        /// A list of all children
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

        /// <summary>
        /// Indicates if this item if file or not. If it is a file it cannot be expanded (so it returns "False")
        /// </summary>
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }

        public bool IsExpanded
        {
            get
            {
                return Children?.Count(f => f != null) > 0;
            }
            set
            {
                //The UI tells us to expand
                if(value == true)
                {
                    Expand();
                }
                //We have to collapse
                else
                {
                    ClearChildren();
                }

            }
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Removes the children from the list
        /// </summary>
        private void ClearChildren()
        {
            Children = new ObservableCollection<DirectoryItemViewModel>();

            if(Type != DirectoryItemType.File)
            {
                Children.Add(null);
            }
        }
        #endregion

        #region Public Commands

        public ICommand ExpandCommand { get; set; }

        #endregion
        /// <summary>
        /// Expand the directory and find the cildren
        /// </summary>
        private void Expand()
        {

        }
    }
}
