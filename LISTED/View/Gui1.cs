using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_LISTED.Model;
using Test_LISTED.View;
using System.Runtime.InteropServices;
using Test_LISTED.Controller;
using System.IO;

namespace Test_LISTED
{
    public partial class Gui1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect,
      int nWidthEllipse,
         int nHeightEllipse

  );
        public Gui1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(0, 64, 64);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };

            /* serialize JSON to a string and then write string to a file */
            System.IO.File.WriteAllText("~\\..\\..\\..\\..\\Model\\UserLogin.txt", JsonConvert.SerializeObject(movie));

            /* serialize JSON directly to a file */
            using (System.IO.StreamWriter file = System.IO.File.CreateText("~\\..\\..\\..\\..\\Model\\UserLogin.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IoDatastorage myModel = new IoDatastorage();
            richTextBox1.Text = myModel.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile);
            //richTextBox1.Text = "Hallo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mySubForm = new Gui2();
            mySubForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabPage tabNew = new TabPage();
            tabNew.Text = "New List";
            tabNew.ImageIndex = this.tabControl1.TabPages.Count + 1;
            this.tabControl1.TabPages.Add(tabNew);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Gui1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(0, 64, 64);

            InputHandler myInputHandler = new InputHandler();
            myInputHandler.int_InputHandler_VerifyUserInput("");
            this.richTextBox1.Text += myInputHandler.int_InputHandler_VerifyUserInput("");

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTodo.Height;
            pnlNav.Top = btnTodo.Top;
            btnTodo.BackColor = Color.FromArgb(0, 64, 64);
            TabPage tabNew = new TabPage();
            tabNew.Text = "New List";
            tabNew.ImageIndex = this.tabControl1.TabPages.Count + 1;
            this.tabControl1.TabPages.Add(tabNew);

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAlarm.Height;
            pnlNav.Top = btnAlarm.Top;
            btnAlarm.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCal.Height;
            pnlNav.Top = btnCal.Top;
            btnCal.BackColor = Color.FromArgb(0, 64, 64);
            Form mySubForm = new Gui2();
            mySubForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogOut.Height;
            pnlNav.Top = btnLogOut.Top;
            btnLogOut.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnTodo_Leave(object sender, EventArgs e)
        {
            btnTodo.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnAlarm_Leave(object sender, EventArgs e)
        {
            btnAlarm.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnCal_Leave(object sender, EventArgs e)
        {
            btnCal.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Gui1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        int n = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            //RichTextBox textBoxNew = new RichTextBox();
            ////System.Drawing.Point myPoint = new System.Drawing.Point(22, 59);
            //System.Drawing.Point myPoint = new System.Drawing.Point(this.richTextBox1.Location.X + 220, this.richTextBox1.Location.Y + 480);

            //textBoxNew.Location = myPoint;
            //textBoxNew.Margin = new System.Windows.Forms.Padding(2);
            //textBoxNew.Size = new System.Drawing.Size(344, 20);
            //textBoxNew.Text = "";
            //textBoxNew.Name = "textBox_" + n.ToString();
            //textBoxNew.TabIndex = this.richTextBox1.TabIndex + n;
            //n++;

            //this.tabPage1.Controls.Add(textBoxNew);
            //this.Controls.Add(textBoxNew);

            //this.richTextBox1.Text = "Hallo";
            //textBoxNew.Text = "Das hier ist ein neuer Textttttttttttttttttttttttttttttttttttttttttt.";


            /* add content from database */
            IoDatastorage mydatastorage = new IoDatastorage();
            string myTest = mydatastorage.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile);

            foreach (string line in myTest.Split("\n"))
            {
                {
                    if (line.StartsWith("list"))
                    {
                        if (line.Substring(5, 1).Equals("1", StringComparison.Ordinal))
                        {
                            {
                                int index = line.IndexOf(",");
                                if(index > 0)
                                {
                                    this.richTextBox1.Text = line.Substring(8, index);
                                }
                                string myLocalSubString = line.Remove(0, index+1);
                                index = myLocalSubString.IndexOf(",");
                                if(index > 0)
                                {
                                    this.richTextBox2.Text = myLocalSubString.Substring(0, index);
                                }
                                myLocalSubString = line.Remove(0, index + 1);
                                index = myLocalSubString.IndexOf(",");
                                if (index > 0)
                                {
                                    this.richTextBox3.Text = myLocalSubString.Substring(0, index);
                                }
                                myLocalSubString = line.Remove(0, index + 1);
                                index = myLocalSubString.IndexOf(",");
                                if (index > 0)
                                {
                                    this.richTextBox4.Text = myLocalSubString.Substring(0, index);
                                }
                                myLocalSubString = line.Remove(0, index + 1);
                                index = myLocalSubString.IndexOf(",");
                                if (index > 0)
                                {
                                    this.richTextBox5.Text = myLocalSubString.Substring(0, index);
                                }

                            }
                        }

                    }                   
            
                }
            }
        }
    }
}
