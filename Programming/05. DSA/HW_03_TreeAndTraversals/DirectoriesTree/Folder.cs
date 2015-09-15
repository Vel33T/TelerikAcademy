using System;

namespace DirectoriesTree
{
    public class Folder
    {
        public string Name { get; set; }
        public File[] Files { get; set; }
        public Folder[] Folders { get; set; }

        public Folder(string name)
        {
            this.Name = name;
        }
    }
}
