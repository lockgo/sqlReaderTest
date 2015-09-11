/*
 * Created by SharpDevelop.
 * User: Lockgo
 * Date: 4/16/2014
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Text;


using System.Collections.Generic;
using System.Linq;

using System.IO;

namespace sqlReaderTest
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            connectionTextBox.Text = "Data Source=COMPUTERname\\DataBaseName;Initial Catalog=CATAGORYNAME;User ID=USERNAME;Password=PASSWORD";


            
            queryTextBox.Text = "select * from DATABASENAME.TABLENAME where id > 70000 order by id DESC";
            //Sql variable Names in the database.
            //You need to change them to the correct type if they are not the correct Value.
            idTextBox1.Text = "id";
            dataTextBox1.Text = "mensagem_excecao";
            dataTextBox2.Text = "stack_trace";
            DirectorytextBox1.Text = "C:\\testa";


            //this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //if (e.KeyChar > 0)
            {
                // Enter key pressed
                //MessageBox.Show(e.KeyChar.ToString());
                richTextBox1.Text = richTextBox1.Text + " " + e.KeyChar.ToString() + " ";
            }
        }


        void Button1Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;
            // make sql connection
            SqlConnection conn = new SqlConnection(connectionTextBox.Text);


            // create a command object
            conn.Open();

            SqlCommand cmd = new SqlCommand(queryTextBox.Text, conn);
            rdr = cmd.ExecuteReader();

            richTextBox1.Text = rdr.VisibleFieldCount.ToString() + "\n\n";

            for (int ij = 0; ij < rdr.VisibleFieldCount; ij++)
            {
                richTextBox1.Text = richTextBox1.Text + rdr.GetFieldType(ij).ToString() + " \t" + rdr.GetName(ij) + "\n";
            }
            int iii = 1;
            int iij = iii++;
            richTextBox1.Text = richTextBox1.Text + iii.ToString() + " " + iij.ToString() + "\n";

            richTextBox1.Text = richTextBox1.Text + rdr.GetFieldType(16).ToString() + "\n";
            //richTextBox1.Text = richTextBox1.Text + rdr.GetFieldType(16).ToString() + "\n";
            while (rdr.Read())
            {
                //write data from the sql query to a richTextBox
                //string contact = (string)rdr["mensagem_excecao"];

                //SQL data from Database
                Int64 idnum = (Int64)rdr[idTextBox1.Text];
                string message = (string)rdr[dataTextBox1.Text];
                string stack = (string)rdr[dataTextBox2.Text];
                //Int64 idnum = (Int64)rdr["id"];
                richTextBox1.Text = richTextBox1.Text + idnum.ToString() + "\t " + message + "\t" + "\n------------" + "\n" + stack + "\n";

            }
            conn.Close();

            //System.Diagnostics.Process.Start(@"c:\testa\ipaddresses.txt");
            //System.Diagnostics.Process.Start(@"‪C:\Windows\System32\cmd.exe"); //this does not work
            //string strCmdText = "/C netstat -b > texttest.txt";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            //System.Diagnostics.Process.Start("CMD.exe");

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            /*
             //Works if you have the folder on your computer.
            using (System.IO.StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd C:\\testa");
                    string fileNameLog = "netStatLog" + DateTime.Now.ToString("d-m-y-_h-mm-ss-tt") + ".txt";
                    //string fileNameLog = "netStatLog" + DateTime.Now.ToString("h-mm-ss-tt")+".txt";
                    //sw.WriteLine(fileNameLog);
                    sw.WriteLine("netstat -b > " + fileNameLog);
                    //sw.WriteLine("netstat -b");

                }
            }
             */
            //p.Close();
            /*
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("mysql -u root -p");
                    sw.WriteLine("mypassword");
                    sw.WriteLine("use mydb;");
                }
            }
            */



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Works if you have the folder on your computer.
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            string commandDirectory = "cd\\";
            string fileNameLog = "netStatLog" + DateTime.Now.ToString("d-m-y-_h-mm-ss-tt") + ".txt";
            string CMDcommand = ("dir > " + fileNameLog);

            p.StartInfo = info;
            p.Start();
            using (System.IO.StreamWriter sw = p.StandardInput)
            {//Only works if ran through command prompt for some reason.
                if (sw.BaseStream.CanWrite)
                {
                    
                    //sw.WriteLine("j:");
                    //sw.WriteLine("cd CodeSupossitory");
                    sw.WriteLine(commandDirectory);
                    sw.WriteLine("cd testa");
                    
                    //string fileNameLog = "netStatLog" + DateTime.Now.ToString("h-mm-ss-tt")+".txt";
                    //sw.WriteLine(fileNameLog);

                    //sw.WriteLine(dataTextBox1.Text + " > " + dataTextBox1.Text + "_" + fileNameLog);
                    //sw.WriteLine("MD" + " newTestDirA");
                    sw.WriteLine("netstat -b > " + fileNameLog);
                    richTextBox1.Text = commandDirectory + " \n" + CMDcommand + " \n" + fileNameLog;
                    //Console.WriteLine();
                    
                    //sw.WriteLine("netstat -b");

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                // Get the directories currently on the C drive.
                //DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

                DirectoryInfo[] cDirs = new DirectoryInfo(DirectorytextBox1.Text).GetDirectories();

                // Write each directory name to a file. 
                using (StreamWriter sw = new StreamWriter(DirectorytextBox1.Text + "\\CDriveDirs.txt"))
                {
                    
                    foreach (DirectoryInfo dir in cDirs)
                    {
                        sw.WriteLine(dir.Name);

                    }
                }

                // Read and show each line from the file. 
                string line = "";
                using (StreamReader sr = new StreamReader(DirectorytextBox1.Text + "\\CDriveDirs.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }



    }
}


