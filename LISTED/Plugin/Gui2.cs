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

namespace Test_LISTED.View
{
    public partial class Gui2 : Form
    {
        public Gui2()
        {
            InitializeComponent();
        }

        private void Gui2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* button to save calendar date */
            Storage.Count = Storage.Count + 1;
            Storage.myLocalDate = this.dtpDatum.Value.Date;
            Storage.myLocalName = this.txtName.Text;
            Storage.myLocalDescription = this.txtBeschreibung.Text;
            Storage.myLocalAlarm = this.cbWecker.Checked;
            
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
