namespace Test_LISTED.View
{
    partial class Gui2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.cbWecker = new System.Windows.Forms.CheckBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beschreibung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wecker";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(169, 19);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 23);
            this.dtpDatum.TabIndex = 3;
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(168, 87);
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(199, 38);
            this.txtBeschreibung.TabIndex = 4;
            // 
            // cbWecker
            // 
            this.cbWecker.AutoSize = true;
            this.cbWecker.Checked = true;
            this.cbWecker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWecker.Location = new System.Drawing.Point(169, 129);
            this.cbWecker.Name = "cbWecker";
            this.cbWecker.Size = new System.Drawing.Size(79, 19);
            this.cbWecker.TabIndex = 6;
            this.cbWecker.Text = "Aktivieren";
            this.cbWecker.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbWecker.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(56, 165);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSpeichern.Size = new System.Drawing.Size(91, 37);
            this.btnSpeichern.TabIndex = 7;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(277, 163);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAbbrechen.Size = new System.Drawing.Size(91, 37);
            this.btnAbbrechen.TabIndex = 8;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 23);
            this.txtName.TabIndex = 10;
            // 
            // Gui2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 218);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cbWecker);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gui2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Gui2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtBeschreibung;
        private System.Windows.Forms.CheckBox cbWecker;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}