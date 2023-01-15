using System.Windows.Forms;

namespace Kursach
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRecords = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnRules = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRecords
            // 
            this.BtnRecords.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_5fNLONJPbu9B;
            this.BtnRecords.FlatAppearance.BorderSize = 0;
            this.BtnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecords.Location = new System.Drawing.Point(800, 610);
            this.BtnRecords.Name = "BtnRecords";
            this.BtnRecords.Size = new System.Drawing.Size(320, 90);
            this.BtnRecords.TabIndex = 0;
            this.BtnRecords.UseVisualStyleBackColor = true;
            this.BtnRecords.Click += new System.EventHandler(this.button1_Click);
            this.BtnRecords.MouseEnter += new System.EventHandler(this.BtnRecords_MouseEnter);
            this.BtnRecords.MouseLeave += new System.EventHandler(this.BtnRecords_MouseLeave);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnPlay.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_b1qreUGNPLCxgdA;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Location = new System.Drawing.Point(800, 500);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(320, 90);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.button2_Click);
            this.BtnPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnPlay_Paint);
            this.BtnPlay.MouseEnter += new System.EventHandler(this.BtnPlay_MouseEnter);
            this.BtnPlay.MouseLeave += new System.EventHandler(this.BtnPlay_MouseLeave);
            // 
            // BtnRules
            // 
            this.BtnRules.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_cf91T8gwoxee5mM;
            this.BtnRules.FlatAppearance.BorderSize = 0;
            this.BtnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRules.Location = new System.Drawing.Point(800, 720);
            this.BtnRules.Name = "BtnRules";
            this.BtnRules.Size = new System.Drawing.Size(320, 90);
            this.BtnRules.TabIndex = 2;
            this.BtnRules.UseVisualStyleBackColor = true;
            this.BtnRules.Click += new System.EventHandler(this.button3_Click);
            this.BtnRules.MouseEnter += new System.EventHandler(this.BtnRules_MouseEnter);
            this.BtnRules.MouseLeave += new System.EventHandler(this.BtnRules_MouseLeave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_GPzpH18bVujQeXb;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(800, 830);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(320, 90);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button4_Click);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Kursach.Properties.Resources.fotor_2023_1_15_2_30_55;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRules);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnRecords);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rise of the dead";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRecords;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnRules;
        private System.Windows.Forms.Button BtnExit;
    }
}

