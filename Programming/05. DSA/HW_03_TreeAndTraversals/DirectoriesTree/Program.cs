using System;
using System.IO;

//TODO: Fix a problem when summing/searching in Windows directory

namespace DirectoriesTree
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Program Files";

            // Building the tree
            Folder mainFolder = new Folder("Program Files");
            BuildingDirectoriesTree(path, ref mainFolder);

            // Locating the folder
            string searchedFolder = "Internet Explorer";
            Folder folder = LocateFolder(mainFolder, searchedFolder);

            // Calculating the size of all files
            long fileSizesSum = CalculateFolderFileSizes(folder);
            Console.WriteLine("The sum of file sizes in folder {0} is: {1}", folder.Name, fileSizesSum);
        }

        private static long CalculateFolderFileSizes(Folder folder)
        {
            long result = 0;

            foreach (var file in folder.Files)
            {
                result += file.Size;
            }

            foreach (var childFolder in folder.Folders)
            {
                result += CalculateFolderFileSizes(childFolder);
            }

            return result;
        }

        private static Folder LocateFolder(Folder mainFolder, string searchedFolder)
        {
            if (mainFolder.Name == searchedFolder)
            {
                return mainFolder;
            }

            Folder foundFolder = null;
            foreach (var folder in mainFolder.Folders)
            {
                if (foundFolder == null)
                {
                    Folder currentFolder = LocateFolder(folder, searchedFolder);
                    if (currentFolder != null)
                    {
                        foundFolder = currentFolder;
                    }
                }
            }

            return foundFolder;
        }

        private static void BuildingDirectoriesTree(string path, ref Folder folder)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            folder = new Folder(dir.Name);

            try
            {
                // Going through all files
                FileInfo[] currentFiles = dir.GetFiles();
                folder.Files = new File[currentFiles.Length];
                for (int i = 0; i < currentFiles.Length; i++)
                {
                    string name = currentFiles[i].Name;
                    long size = currentFiles[i].Length;

                    folder.Files[i] = new File(name, size);
                }

                // Going through all folders
                DirectoryInfo[] currentDirs = dir.GetDirectories();
                folder.Folders = new Folder[currentDirs.Length];
                for (int i = 0; i < currentDirs.Length; i++)
                {
                    string name = currentDirs[i].Name;
                    Folder currentFolder = new Folder(name);
                    BuildingDirectoriesTree(currentDirs[i].FullName, ref currentFolder);
                    folder.Folders[i] = currentFolder;
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Cannot access directory {0}!", path);
                return;
            }
        }
    }
}
