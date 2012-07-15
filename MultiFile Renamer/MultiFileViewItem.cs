using System;
using System.Windows.Forms;

namespace MultiFile_Renamer
{
    class MultiFileViewItem : ListViewItem
    {
        //o nome da pasta é FolderPath, o nome do ficheiro é o escrito em Text
        public String FolderPath;
        public String CreationTime;

        public MultiFileViewItem()
        {
        }

        public MultiFileViewItem(String text, String folderPath, String creationTime)
        {            
            Text = text;

            if (FormMain.IsRootDrive(folderPath))
                FolderPath =  folderPath;
            else
                FolderPath =  folderPath + "\\";

            CreationTime = creationTime;                        
        }

        public String GetFullPath()
        {
            return FolderPath + Text;
        }

        public String GetOriginalName()
        {
            return Text.Substring(0, Text.LastIndexOf('.'));
        }

        public String GetExtension()
        {
            return Text.Substring(Text.LastIndexOf('.') + 1).ToLower();
        }
    }
}
