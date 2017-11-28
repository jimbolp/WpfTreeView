using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTreeView
{
    /// <summary>
    /// Information about directory items such  as drives, folders and files
    /// </summary>
    public class DirectoryItem
    {
        public DirectoryItemType Type { get; set; }
        /// <summary>
        /// The absolute path to this item
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// The name of this directory item
        /// </summary>
        public string Name { get { return Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }
        

    }
}
