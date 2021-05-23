
namespace LISTED.Plugin
{
    partial class GuiAlarm
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
            this.dateTimePickerAlarm = new System.Windows.Forms.DateTimePicker();
            this.btnStartAlarm = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerAlarm
            // 
            this.dateTimePickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAlarm.Location = new System.Drawing.Point(81, 12);
            this.dateTimePickerAlarm.Name = "dateTimePickerAlarm";
            this.dateTimePickerAlarm.Size = new System.Drawing.Size(92, 23);
            this.dateTimePickerAlarm.TabIndex = 0;
            // 
            // btnStartAlarm
            // 
            this.btnStartAlarm.Location = new System.Drawing.Point(12, 78);
            this.btnStartAlarm.Name = "btnStartAlarm";
            this.btnStartAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnStartAlarm.TabIndex = 1;
            this.btnStartAlarm.Text = "Start!";
            this.btnStartAlarm.UseVisualStyleBackColor = true;
            this.btnStartAlarm.Click += new System.EventHandler(this.btnStartAlarm_Click);
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(161, 78);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnStopAlarm.TabIndex = 2;
            this.btnStopAlarm.Text = "Stop!";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(103, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // GuiAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 125);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.btnStartAlarm);
            this.Controls.Add(this.dateTimePickerAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GuiAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.GuiAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAlarm;
        private System.Windows.Forms.Button btnStartAlarm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
    }
}