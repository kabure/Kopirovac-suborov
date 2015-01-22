using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopirovac_suborov
{
    public partial class OknoMain : Form
    {
        const int pocetZnakovVNazve = 6;

        public OknoMain()
        {
            InitializeComponent();
        }

        private void btnCestaZdroj_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            tbZdroj.Text = folderBrowser.SelectedPath;
        }

        private void btnCestaCiel_Click(object sender, EventArgs e)
        {
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            //tbCiel.Text = appPath;
           // Process.Start(@"c:\test");
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            tbCiel.Text = folderBrowser.SelectedPath;
            //string[] files = Directory.GetFiles(folderBrowser.SelectedPath);

            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "C# Corner Open File Dialog";
            //fdlg.InitialDirectory = @"c:\";
            //fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            //fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            //if (fdlg.ShowDialog() == DialogResult.OK)
            //{
            //    tbCiel.Text = fdlg.FileName;
            //}
        }

       
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void btnKopirovat_Click(object sender, EventArgs e)
        {
            

            /*
             * zavola funkciu parsovanie
             * odstrani so stringu medzeri
             * vo forech bude volat funkciu copy s parametrami cesta + nazov suboru
             * pridat pocitadla
             * tabulku uspesne skopirovane a neuspesne zobrazit az po kliknuti na kopirovat
             */
            statusLbl.Text = "Kopíruje";
            ArrayList folderList = new ArrayList();
            ArrayList folderListOk = new ArrayList();
            ArrayList folderListError = new ArrayList();

            string cestaFolderList = "";
            string foldetListString = tbZoznam.Text;
            char[] path = new char[3];
            string endDirectory = "";
            int i = 0;

            char[] delimiterChars = { ' ', '\n', ',', '\r' };             //znaku podla ktorych sa bude parsovat vstup
            string[] folderListSplit = foldetListString.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);     // prikaz split oddeli podla medzeri a enterov jewdlotlive stringy

            foreach (string s in folderListSplit)
            {
                folderList.Add(s.Replace(" ", ""));
            }

            /*
             * Doplnenie nul do nazvu napr. subor 3254 premenuje na 003254
             */ 
            foreach (string s in folderList)
            {
                cestaFolderList = "";
                if(pocetZnakovVNazve >= s.Length)
                {
                    int pocetDoplnujucichZnakov = pocetZnakovVNazve - s.Length;
                    for (i = 0; i < pocetDoplnujucichZnakov; i++)
                    {
                        cestaFolderList = "0" + cestaFolderList;
                    }
                    cestaFolderList += s;
                    i = 0;
                    endDirectory = "";
                    foreach (char c in cestaFolderList)
                    {
                        if (i <= 2)
                        {
                            path[i] = c;
                        }
                        else
                        {
                            endDirectory += c;
                        }
                        i++;
                    }


                    // private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
                    DirectoryCopy(tbZdroj.Text + "\\" + path[0] + "\\" + path[1] + "\\" + path[2] + "\\" + endDirectory, tbCiel.Text + "\\" + s, true);
                    if (Directory.Exists(tbCiel + "\\" + s))
                    {
                        folderListError.Add(s);
                        tbChyba.Text = tbChyba.Text + Environment.NewLine + s;
                    }
                    else
                    {
                        folderListOk.Add(s);
                        tbUspesne.Text = tbUspesne.Text + Environment.NewLine + s;
                    }
                    statusLbl.Text = "Hotovo";
                }
                
                else 
                {
                    statusLbl.Text = "Je potrebna aktualizacia. Pocet znakov v nazve presahuje rozsah";
                    //return "error";

                }

               

            }

            tbUspesne.Visible = true;
            tbChyba.Visible = true;
            lblChyba.Visible = true;
            lblUspesne.Visible = true;
            lblPocetZadanych.Visible = true;
            lblPocetZadanych.Text = folderList.Count.ToString();
            lblPocitadloOk.Visible = true;
            lblPocitadloOk.Text = folderListOk.Count.ToString();
            lblPocitadloError.Visible = true;
            lblPocitadloError.Text = folderListError.Count.ToString();
            
            //return "OK";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewFind_Click(object sender, EventArgs e)
        {
            tbUspesne.Visible = false;
            tbChyba.Visible = false;
            lblChyba.Visible = false;
            lblUspesne.Visible = false;
            lblPocetZadanych.Visible = false;
            lblPocetZadanych.Text = "";
            lblPocitadloOk.Visible = false;
            lblPocitadloOk.Text = "";
            lblPocitadloError.Visible = false;
            lblPocitadloError.Text = "";
            tbChyba.Text = "";
            tbZoznam.Text = "";
            tbUspesne.Text = "";
            //tbZdroj.Text = "";
            tbCiel.Text = "";
            statusLbl.Text = "Pripravený";
        }

        private void oProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.okno = new OknoOPrograme();
            Program.okno.Show();
            Program.oknoMain.Enabled= false;
            
        }

        


    }
}
