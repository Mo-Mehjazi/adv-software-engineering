using Newtonsoft.Json;
using System;
using System.Collections;
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
using System.Collections.Generic;

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
            load_Database();
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


            if ((this.richTextBox1.Text.Length == 0) && (Storage.Count == 1))
            {
                this.richTextBox1.Text = Storage.myLocalName;
                string myTest = Storage.myLocalDate.ToString();
                System.Diagnostics.Debug.WriteLine(myTest);
                this.richTextBox6.Text = Storage.myLocalDate.ToString();
            }
           
            if ((this.richTextBox2.Text.Length == 0) && (Storage.Count == 2))
            {
                this.richTextBox2.Text = Storage.myLocalName;
                this.richTextBox7.Text = Storage.myLocalDate.ToString();
            }

            if ((this.richTextBox3.Text.Length == 0) && (Storage.Count == 3))
            {
                this.richTextBox3.Text = Storage.myLocalName;
                this.richTextBox8.Text = Storage.myLocalDate.ToString();
            }

            if ((this.richTextBox4.Text.Length == 0) && (Storage.Count == 4))
            {
                this.richTextBox4.Text = Storage.myLocalName;
                this.richTextBox9.Text = Storage.myLocalDate.ToString();
            }

            if ((this.richTextBox5.Text.Length == 0) && (Storage.Count == 5))
            {
                this.richTextBox5.Text = Storage.myLocalName;
                this.richTextBox10.Text = Storage.myLocalDate.ToString();
            }

            string myInput = "";
            if (richTextBox1.Text.Length > 0)
            {
                myInput = (this.richTextBox1.Text);
                myInput += "[" + this.richTextBox6.Text +"]";
            }

            //if (new FileInfo(Storage.s_PathTextfile).Length != 0)
            {
                if (richTextBox2.Text.Length > 0)
                {
                    myInput += (",");
                    myInput += (this.richTextBox2.Text);
                    myInput += "[" + this.richTextBox7.Text + "]";
                }
                if (richTextBox3.Text.Length > 0)
                {
                    myInput += (",");
                    myInput += (this.richTextBox3.Text);
                    myInput += "[" + this.richTextBox8.Text + "]";
                }
                if (richTextBox4.Text.Length > 0)
                {
                    myInput += (",");
                    myInput += (this.richTextBox4.Text);
                    myInput += "[" + this.richTextBox9.Text + "]";
                }
                if (richTextBox5.Text.Length > 0)
                {
                    myInput += (",");
                    myInput += (this.richTextBox5.Text);
                    myInput += "[" + this.richTextBox10.Text + "]";
                }
            }

            myModel.int_IoDatastorage_WriteDataToStorage(myInput, Storage.s_PathTextfile);

            /* is calendar set? */
            DateTime dateTime = new DateTime();
            dateTime = dateTime.Date;
            int result = DateTime.Compare(Storage.myLocalDate.Date, dateTime);
            if ((Storage.myLocalAlarm) && (result != 0))
            {
                if (this.richTextBox11.Text.Length == 0)
                {
                    this.richTextBox11.Text = Storage.myLocalName;
                }

                else if (this.richTextBox12.Text.Length == 0)
                {
                    this.richTextBox12.Text = Storage.myLocalName;
                }
            }
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
            if (this.btnLogOut.Text.Equals("Log in!"))
            {
                this.btnLogOut.Text = "Log out!";

                string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                
                string myName = username.Substring(username.IndexOf("\\")+1);
                this.userLabel.Text = myName;
                
            }
            else
            {
                this.btnLogOut.Text = "Log in!";
                this.userLabel.Text = "User Name";
            }
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

        private void load_Database()
        {
            /* add content from database */
            IoDatastorage mydatastorage = new IoDatastorage();
            string myInput = mydatastorage.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile);

            if (mydatastorage.int_IoDatastorage_WriteDataToStorage(myInput, Storage.s_PathTextfile) != 1)
            {
                this.richTextBox3.Text = "An error occured.";
            }

            /* EMPTY ALL CONTENT & READ FROM DATABASE */
            this.richTextBox1.Text = "";
            this.richTextBox2.Text = "";
            this.richTextBox3.Text = "";
            this.richTextBox4.Text = "";
            this.richTextBox5.Text = "";
            this.richTextBox6.Text = "";
            this.richTextBox7.Text = "";
            this.richTextBox8.Text = "";
            this.richTextBox9.Text = "";
            this.richTextBox10.Text = "";

            try
            {
                int n = 0;
                ArrayList arrayPart = new ArrayList();
                ArrayList arrayPartDate = new ArrayList();


                foreach (string part in myInput.Split(","))
                {
                    string myLocalItem = part.Substring(0, part.IndexOf("["));
                    arrayPart.Add(myLocalItem);
                    string myLocalDatum = part.Substring(part.IndexOf("[") + 1, 11);
                    //System.Diagnostics.Debug.WriteLine("HIER HIER HIER: " + part.Substring(part.IndexOf("[")) + " " + part.Substring(part.IndexOf("]")-1));
                    arrayPartDate.Add(myLocalDatum);
                }
                foreach (Object obj in arrayPart)
                {
                    if (n == 0)
                    {
                        this.richTextBox1.Text = obj.ToString();
                    }
                    if (n == 1)
                    {
                        this.richTextBox2.Text = obj.ToString();
                    }
                    if (n == 2)
                    {
                        this.richTextBox3.Text = obj.ToString();
                    }
                    if (n == 3)
                    {
                        this.richTextBox4.Text = obj.ToString();
                    }
                    if (n == 4)
                    {
                        this.richTextBox5.Text = obj.ToString();
                    }
                    n++;
                }
                n = 0;
                //foreach(string part in myInput.Split("["))
                //{
                //    arrayPart.Clear();
                //    arrayPart.Add(part.Substring(0, myInput.IndexOf("]")));
                //}
                foreach (Object obj in arrayPartDate)
                {
                    if (n == 0)
                    {
                        this.richTextBox6.Text = obj.ToString();
                    }
                    if (n == 1)
                    {
                        this.richTextBox7.Text = obj.ToString();
                    }
                    if (n == 2)
                    {
                        this.richTextBox8.Text = obj.ToString();
                    }
                    if (n == 3)
                    {
                        this.richTextBox9.Text = obj.ToString();
                    }
                    if (n == 4)
                    {
                        this.richTextBox10.Text = obj.ToString();
                    }
                    n++;
                }

            }
            catch (System.ArgumentOutOfRangeException outofRange)
            {
                System.Diagnostics.Debug.WriteLine(outofRange.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_Database();
        }
    }
}
