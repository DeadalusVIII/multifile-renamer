using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MultiFile_Renamer
{
    public class ExplorerIntegrationInstaller
    {
        private static String _executablePath = Application.ExecutablePath;
        private static String _iconPath = _executablePath.Substring(0, _executablePath.LastIndexOf("\\")) + "\\RenameIcon.ico";

        public static void Install()
        {
            RegistryKey renamerKey;

            //first, let's check if it already exists
            /*if ((renamerKey = Registry.ClassesRoot.OpenSubKey("Directory\\shell\\MultiFile Renamer")) != null)
            {
                renamerKey.Close();
                throw new Exception("MultiFile Renamer Explorer Integration has already been installed!");
            }*/
            

            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey("Directory\\shell",true);
            if (shellKey == null)
                throw new Exception("Your system's registry may be inconsistent.");

            renamerKey = shellKey.CreateSubKey("MultiFile Renamer");
            if(renamerKey == null)
                throw new Exception("Your system's registry may be write-protected.");

            //set the menu name and icon
            renamerKey.SetValue("", "Open MultiFile Renamer on this folder");
            renamerKey.SetValue("Icon", _iconPath,RegistryValueKind.ExpandString);

            //set the path to the executable
            RegistryKey commandKey = renamerKey.CreateSubKey("command");
            if(commandKey == null)
                throw new Exception("Your system's registry may be write-protected.");

            commandKey.SetValue("", _executablePath + " \"%1\"");
                
            //close all keys
            commandKey.Close();
            renamerKey.Close();
            shellKey.Close();
        }

        public static void Uninstall()
        {
            //try to access the key to check if it exists
            RegistryKey renamerKey = Registry.ClassesRoot.OpenSubKey("Directory\\shell\\MultiFile Renamer");

            if (renamerKey == null)
                throw new Exception("MultiFile Renamer is currently not installed on Windows Explorer Context Menu.");

            //close the key now that we don't need it
            renamerKey.Close();

            //now 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey("Directory\\shell", true);

            if (shellKey == null)
                throw new Exception("Your system's registry may be inconsistent.");

            shellKey.DeleteSubKeyTree("MultiFile Renamer");
            shellKey.Close();
        }
    }
}
