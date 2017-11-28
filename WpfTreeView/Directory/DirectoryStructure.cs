using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfTreeView
{
    /// <summary>
    /// A helper class to query information about directories
    /// </summary>
    public static class DirectoryStructure
    {
        public static List<DirectoryItem> GetLogicalDrives()
        {
            return Directory.GetLogicalDrives().Select(drive => new DirectoryItem() { FullPath = drive, Type = DirectoryItemType.Drive }).ToList();
        }


        /// <summary>
        /// Gets the directory top-level contents
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            //Create empty liist
            List<DirectoryItem> items = new List<DirectoryItem>();

            #region Get Directories
            try
            {
                var directories = Directory.GetDirectories(fullPath).ToList();
                items.AddRange(directories.Select(dir => new DirectoryItem() { FullPath = dir, Type = DirectoryItemType.Folder }).ToList());
            }
            catch (Exception) { }

            #endregion
            #region Get Files

            try
            {
                var files = Directory.GetFiles(fullPath).ToList();
                items.AddRange(files.Select(file => new DirectoryItem() { FullPath = file, Type = DirectoryItemType.File }).ToList());
            }
            catch (Exception) { }

            #endregion

            return items;
        }

        /// <summary>
        /// Find the file/folder name from a full path
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static string GetFileFolderName(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
                return string.Empty;
            string normalizedPath = directoryPath.Replace('/', '\\');
            int lastIndex = normalizedPath.LastIndexOf('\\');

            if (lastIndex <= 0)
            {
                return directoryPath;
            }

            return directoryPath.Substring(lastIndex + 1);
        }
    }
}
