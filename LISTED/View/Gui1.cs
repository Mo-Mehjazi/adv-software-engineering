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

namespace Test_LISTED
{
    public partial class Gui1 : Form
    {
        public Gui1()
        {
            InitializeComponent();
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
    }
}
