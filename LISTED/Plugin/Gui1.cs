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
using LISTED.Plugin;
using Test_LISTED.Kern;

//using Test_LISTED.Adapter;

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
            btnHome.BackColor = Color.FromArgb(0, 80, 80);
            load_Database();
        }

        private void WriteContentIntoTextboxes()
        {
            /* Write the content as given from count into the next empty textbox. */

            switch (Storage.Count)
            {
                case 1:
                    if ((this.richTextBox1.Text.Length == 0))
                    {
                        this.richTextBox1.Text = Storage.myLocalName;
                        this.richTextBox6.Text = Storage.myLocalDate.ToString();
                    }
                    break;
                case 2:
                    if ((this.richTextBox2.Text.Length == 0))
                    {
                        this.richTextBox2.Text = Storage.myLocalName;
                        this.richTextBox7.Text = Storage.myLocalDate.ToString();
                    }
                    break;
                case 3:
                    if ((this.richTextBox3.Text.Length == 0))
                    {
                        this.richTextBox3.Text = Storage.myLocalName;
                        this.richTextBox8.Text = Storage.myLocalDate.ToString();
                    }
                    break;
                case 4:
                    if ((this.richTextBox4.Text.Length == 0))
                    {
                        this.richTextBox4.Text = Storage.myLocalName;
                        this.richTextBox9.Text = Storage.myLocalDate.ToString();
                    }
                    break;
                case 5:
                    if ((this.richTextBox5.Text.Length == 0))
                    {
                        this.richTextBox5.Text = Storage.myLocalName;
                        this.richTextBox10.Text = Storage.myLocalDate.ToString();
                    }
                    break;
                default:
                    break;
            }

            return;
        }

        public string FormalizeContentToString()
        {
            /* Check if text boxes have content, if true take their content and add formalized string to myInput. */

            string myInput = "";

            if (richTextBox1.Text.Length > 0)
            {
                myInput = (this.richTextBox1.Text);
                myInput += "[" + this.richTextBox6.Text + "]";
            }

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

            return myInput;
        }

        private void WriteContentIntoEmptyRichTextBox()
        {
            /* Check if the text boxes are empty, if true fill the next in order with content from storage. */

            if (this.txtboxUpevent1.Text.Length == 0)
            {
                this.txtboxUpevent1.Text = Storage.myLocalName;
            }

            else if (this.txtboxUpevent2.Text.Length == 0)
            {
                this.txtboxUpevent2.Text = Storage.myLocalName;
            }

            return;
        }

        public void btn_Save_Click(object sender, EventArgs e)
        {
            /* Write content to Gui (1), into data storage (2) and check if date is today to write it to another text box (3). */

            IoDatastorage myModel = new IoDatastorage();
            DateTime dateTime = new DateTime();

            WriteContentIntoTextboxes(); /* 1 */

            myModel.int_IoDatastorage_WriteDataToStorage(FormalizeContentToString(), Storage.s_PathTextfile); /* 2 */

            if ((Storage.myLocalAlarm) && (0 != (DateTime.Compare(Storage.myLocalDate.Date, dateTime.Date)))) /* 3 */
            {
                WriteContentIntoEmptyRichTextBox();
            }

            return;
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
            createNewList();

        }

        public void createNewList()
        {

            TabPage tabNew = new TabPage();
            TabsControl myTabsControl = new TabsControl();
            myTabsControl.v_TabControl_CreateNewTab(tabNew, "List" + Storage.listNum);
            tabNew.ImageIndex = this.tabControlMain.TabPages.Count + 1;
            this.tabControlMain.TabPages.Add(tabNew);
            Storage.listNum++;
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAlarm.Height;
            pnlNav.Top = btnAlarm.Top;
            btnAlarm.BackColor = Color.FromArgb(0, 64, 64);
            Form myAlarmForm = new GuiAlarm();
            myAlarmForm.ShowDialog();
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

                UserLogin myUserLogin = new UserLogin();
                string myName = myUserLogin.GetUserByWindowsId().Substring(myUserLogin.GetUserByWindowsId().IndexOf("\\") + 1);
                this.userLabel.Text = myName;

            }
            else
            {
                this.btnLogOut.Text = "Log in!";
                this.userLabel.Text = "User Name";
            }
        }
        private void bg_Color(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 80, 80);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            bg_Color(btnHome);
        }

        private void btnTodo_Leave(object sender, EventArgs e)
        {
            bg_Color(btnTodo);
        }

        private void btnAlarm_Leave(object sender, EventArgs e)
        {
            bg_Color(btnAlarm);
        }

        private void btnCal_Leave(object sender, EventArgs e)
        {
            bg_Color(btnCal);
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            bg_Color(btnLogOut);
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


        public void DeleteContentFromAllTextboxes()
        {
            /* delete contents from textboxes */
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

            return;
        }

        public void WriteCalendarNameFromDatabaseToTextBoxes(ArrayList arrayPart)
        {
            int n = 0;

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

            return;
        }

        public void WriteDateFromDatabaseToTextBoxes(ArrayList arrayPartDate)
        {
            int n = 0;
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

            return;
        }

        public ArrayList SplitDataFromStorageName(string myInput)
        {
            /* create array list from input from datastorage */

            ArrayList arrayPart = new ArrayList();

            foreach (string part in myInput.Split(","))
            {
                arrayPart.Add(part.Substring(0, part.IndexOf("[")));
            }

            return arrayPart;
        }

        public ArrayList SplitDataFromStorageDate(string myInput)
        {
            /* create array list from input from datastorage */

            ArrayList arrayPartDate = new ArrayList();

            foreach (string part in myInput.Split(","))
            {
                arrayPartDate.Add(part.Substring(part.IndexOf("[") + 1, 11));
            }

            return arrayPartDate;
        }

        private void load_Database()
        {
            /* add content from database */
            IoDatastorage mydatastorage = new IoDatastorage();
            string myInput = mydatastorage.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile);

            try
            {
                /* try to print data from data storage to the gui */
                DeleteContentFromAllTextboxes();
                WriteCalendarNameFromDatabaseToTextBoxes(SplitDataFromStorageName(myInput));
                WriteDateFromDatabaseToTextBoxes(SplitDataFromStorageDate(myInput));
            }
            catch (System.ArgumentOutOfRangeException outofRange)
            {
                System.Diagnostics.Debug.WriteLine(outofRange.Message);
            }
            catch (FileNotFoundException e)
            {
                this.richTextBox3.Text = "An error occured.";
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            return;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtboxHlights1.Text.Length != 0)
            {
                this.txtboxHlights1.Text = this.richTextBox2.Text;
            }
            else if (this.txtboxHlights2.Text.Length != 0)
            {
                this.txtboxHlights2.Text = this.richTextBox2.Text;
            }

            return;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtboxHlights1.Text.Length != 0)
            {
                this.txtboxHlights1.Text = this.richTextBox3.Text;
            }
            else if (this.txtboxHlights2.Text.Length != 0)
            {
                this.txtboxHlights2.Text = this.richTextBox3.Text;
            }

            return;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtboxHlights1.Text.Length != 0)
            {
                this.txtboxHlights1.Text = this.richTextBox4.Text;
            }
            else if (this.txtboxHlights2.Text.Length != 0)
            {
                this.txtboxHlights2.Text = this.richTextBox4.Text;
            }

            return;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtboxHlights1.Text.Length != 0)
            {
                this.txtboxHlights1.Text = this.richTextBox5.Text;
            }
            else if (this.txtboxHlights2.Text.Length != 0)
            {
                this.txtboxHlights2.Text = this.richTextBox5.Text;
            }

            return;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.checkBox1.Checked)
            {
                if (this.txtboxHlights1.Text.Length == 0)
                {
                    this.txtboxHlights1.Text = this.richTextBox1.Text;
                    return;
                }
                else if (this.txtboxHlights2.Text.Length == 0)
                {
                    this.txtboxHlights2.Text = this.richTextBox1.Text;
                    return;
                }
            }
            else
            {
                if (this.txtboxHlights1.Text == this.richTextBox1.Text)
                {
                    this.txtboxHlights1.Text = "";
                    return;
                }
                else if (this.txtboxHlights2.Text == this.richTextBox1.Text)
                {
                    this.txtboxHlights2.Text = "";
                    return;
                }
            }

            return;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.checkBox2.Checked)
            {
                if (this.txtboxHlights1.Text.Length == 0)
                {
                    this.txtboxHlights1.Text = this.richTextBox2.Text;
                    return;
                }
                else if (this.txtboxHlights2.Text.Length == 0)
                {
                    this.txtboxHlights2.Text = this.richTextBox2.Text;
                    return;
                }
            }
            else
            {
                if (this.txtboxHlights1.Text == this.richTextBox2.Text)
                {
                    this.txtboxHlights1.Text = "";
                    return;
                }
                else if (this.txtboxHlights2.Text == this.richTextBox2.Text)
                {
                    this.txtboxHlights2.Text = "";
                    return;
                }
            }

            return;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.checkBox3.Checked)
            {
                if (this.txtboxHlights1.Text.Length == 0)
                {
                    this.txtboxHlights1.Text = this.richTextBox3.Text;
                    return;
                }
                else if (this.txtboxHlights2.Text.Length == 0)
                {
                    this.txtboxHlights2.Text = this.richTextBox3.Text;
                    return;
                }
            }
            else
            {
                if (this.txtboxHlights1.Text == this.richTextBox3.Text)
                {
                    this.txtboxHlights1.Text = "";
                    return;
                }
                else if (this.txtboxHlights2.Text == this.richTextBox3.Text)
                {
                    this.txtboxHlights2.Text = "";
                    return;
                }
            }

            return;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.checkBox4.Checked)
            {
                if (this.txtboxHlights1.Text.Length == 0)
                {
                    this.txtboxHlights1.Text = this.richTextBox4.Text;
                    return;
                }
                else if (this.txtboxHlights2.Text.Length == 0)
                {
                    this.txtboxHlights2.Text = this.richTextBox4.Text;
                    return;
                }
            }
            else
            {
                if (this.txtboxHlights1.Text == this.richTextBox4.Text)
                {
                    this.txtboxHlights1.Text = "";
                    return;
                }
                else if (this.txtboxHlights2.Text == this.richTextBox4.Text)
                {
                    this.txtboxHlights2.Text = "";
                    return;
                }
            }

            return;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.checkBox5.Checked)
            {
                if (this.txtboxHlights1.Text.Length == 0)
                {
                    this.txtboxHlights1.Text = this.richTextBox5.Text;
                    return;
                }
                else if (this.txtboxHlights2.Text.Length == 0)
                {
                    this.txtboxHlights2.Text = this.richTextBox5.Text;
                    return;
                }
            }
            else
            {
                if (this.txtboxHlights1.Text == this.richTextBox5.Text)
                {
                    this.txtboxHlights1.Text = "";
                    return;
                }
                else if (this.txtboxHlights2.Text == this.richTextBox5.Text)
                {
                    this.txtboxHlights2.Text = "";
                    return;
                }
            }

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String myString = "Das ist ein Text.";
            //InputHandler myInputHandler = new InputHandler();
            //string string_MyResult1 = myInputHandler.int_InputHandler_VerifyUserInput(myString);
            //Console.WriteLine(string_MyResult1);
            //Console.ReadLine();

        }
    }
}
