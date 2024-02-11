using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MovieSelector2._0
{
    public partial class Form1 : Form
    {

        private static string FindProjectDirectory(string currentDirectory)
        {
            while (!File.Exists(Path.Combine(currentDirectory, "MovieSelector2.0.csproj")))
            {
                string parentDirectory = Directory.GetParent(currentDirectory)?.FullName;

                if (parentDirectory == null || parentDirectory == currentDirectory)
                    return null;

                currentDirectory = parentDirectory;
            }

            return currentDirectory;
        }
        static void create_folders()
        {


            string AppPath = Application.StartupPath;
            
            string projectDirectory = FindProjectDirectory(AppPath);
            string dir = Path.Combine(projectDirectory, "YourMovies\\Not Watched");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            dir = Path.Combine(projectDirectory, "YourMovies\\Watched");
            if (!Directory.Exists(dir))
            {

                Directory.CreateDirectory(dir);
            }
            dir = Path.Combine(AppPath, "Random");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                File.Copy(Path.Combine(AppPath, "f.mp4"), Path.Combine(dir, "f.mp4"));
            }
        }
        public Form1()
        {
            InitializeComponent();
            create_folders();
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "DontShow.txt")))
            {
                Form2 form2 = new Form2();
                form2.ShowDialog(this);
            }
        }

        private static string CreatePaths(int f)
        {
            
            string Folder = "";
            if (f == 0)
            {
                Folder = "Not ";
            }
            Folder += "Watched";
            string fullPath = Path.GetFullPath(Application.StartupPath);
          
            string projectDirectory = FindProjectDirectory(fullPath);
            return Path.Combine(projectDirectory, "YourMovies", Folder);

        }
        public static string[] Movies = { CreatePaths(0), CreatePaths(1) };

        private void FileCopy(int f)
        {

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.InitialDirectory = @"C:\";
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    File.Copy(file, Path.Combine(Movies[f], Path.GetFileName(file)));
                }

                DialogResult result = MessageBox.Show("Do you want to delete the files from their original directory (no files will be lost, just moved)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        File.Delete(file);
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv;*.webm;*.m4v;*.mpg;*.mpeg;*.3gp;*.asf;*.rm;*.swf;*.vob;*.ts;*.m2ts;*.mts|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a video file";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;


        }


        private void CopySomeToRandom(int f)
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.InitialDirectory = Movies[f];
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    File.Copy(file, Path.Combine(Application.StartupPath, "Random", Path.GetFileName(file)));
                }
            }
        }

        private void CopyAllToRandom(int f)
        {

            foreach (string file in Directory.GetFiles(Movies[f]))
            {
                //MessageBox.Show(file);
                File.Copy(file, Path.Combine(Application.StartupPath, "Random", Path.GetFileName(file)));
            }
        }

        
        private void AddChoices(int f)
        {
            DialogResult result = MessageBox.Show("Do you want to include movies you have {Path.GetFileName(Movies[f]).ToLower()} in the random choice?", "Confirmation", MessageBoxButtons.YesNo), result1, return2;
            if (result == DialogResult.Yes)
            {
            op1:
                result1 = MessageBox.Show($"Do you want to include all movies you have {Path.GetFileName(Movies[f]).ToLower()} in the random choice?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result1 == DialogResult.Cancel)
                {
                    return2 = MessageBox.Show($"Are you sure you want to cancel importing {Path.GetFileName(Movies[f]).ToLower()} movies?", "Confirmation", MessageBoxButtons.YesNo);
                    if (return2 == DialogResult.No)
                    {
                        goto op1;
                    }
                }
                else
                {
                    DialogResult dr=DialogResult.Yes;
                    if (Directory.GetFiles(Movies[f]).Length ==0 )
                    {
                        dr = MessageBox.Show($"You don't have {Path.GetFileName(Movies[f]).ToLower()} movies imported.\n Would you like to add some?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            FileCopy(f);
                        }
                    }
                    if (dr == DialogResult.Yes)
                    {
                        if (result1 == DialogResult.No)
                        {
                            CopySomeToRandom(f);
                        }
                        else
                        {
                            CopyAllToRandom(f);
                        }
                    }
                }
            }
        }

        private void MovieRandomizer_Click(object sender, EventArgs e)
        {
            
            AddChoices(0);
            AddChoices(1);

            string[] FILES = Directory.GetFiles(Application.StartupPath + "\\Random");
            Random rnd = new Random();

            string video;
            do
            {
                // MessageBox.Show(video);
                video = FILES[rnd.Next(FILES.Length)];

            } while (Path.GetFileNameWithoutExtension(video) == "f" && FILES.Length > 1);
            bool f = false;
            if (Path.GetFileNameWithoutExtension(video) == "f")
            {
               
                Process.Start(new ProcessStartInfo
                {
                    
                    FileName = Application.StartupPath+"\\f.mp4",
                    UseShellExecute = true
                }); ;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {

                    //MessageBox.Show(Convert.ToString(i));
                    foreach (string file in Directory.GetFiles(Movies[i]))
                    {
                        Console.Error.WriteLine(file);
                        if (Path.GetFileName(file) == Path.GetFileName(video))
                        {

                            File.Move(file, Path.Combine(Movies[1], Path.GetFileName(file)));
                            string filePathToOpen = Path.Combine(Movies[1], Path.GetFileName(file));
                            try
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = filePathToOpen,
                                    UseShellExecute = true
                                });
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            f = true;
                            break;
                        }

                        if (f)
                            break;
                    }

                }
            }
            foreach (string file in FILES)
            {
                File.Delete(file);
            }
            Directory.Delete(Path.Combine(Application.StartupPath, "Random"));
            Close();
        }

        private void AddMoviesToWatchedFolder_Click(object sender, EventArgs e)
        {
            FileCopy(1);
        }

        private void AddMoviesToNotWatchedFolder_Click(object sender, EventArgs e)
        {
            FileCopy(0);
        }
    }
}
