using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;




namespace MovieSelector2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        static void CreateShortcut(string targetPath, string shortcutPath, string iconPath = null)
        {
            try
            {
                
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

                
                shortcut.TargetPath = targetPath;

                
                if (!string.IsNullOrEmpty(iconPath))
                    shortcut.IconLocation = iconPath;

                
                shortcut.Save();

                Console.WriteLine("Shortcut created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating shortcut: " + ex.Message);
            }
        }
    
        private void CheckBoxCheck()
         {
             if (ShowMessage.CheckState == CheckState.Checked)
             {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "DontShow.txt"));
             }
         }
        private void CreateShortCut_Click(object sender, EventArgs e)
        {
            string targetPath = Application.ExecutablePath;
            string shortcutName = "MovieSelector";
            string iconPath = Path.Combine(Application.StartupPath,"Icon.ico");

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutPath = Path.Combine(desktopPath, $"{shortcutName}.lnk");

            CreateShortcut(targetPath, shortcutPath, iconPath);

            CheckBoxCheck();
            Close();
        }


        private void CloseForm_Click(object sender, EventArgs e)
        {
            CheckBoxCheck();
            Close();
        }
    }
}
