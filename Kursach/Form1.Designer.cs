
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnRecords = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnRules = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRecords
            // 
            this.BtnRecords.Location = new System.Drawing.Point(490, 160);
            this.BtnRecords.Name = "BtnRecords";
            this.BtnRecords.Size = new System.Drawing.Size(320, 90);
            this.BtnRecords.TabIndex = 0;
            this.BtnRecords.Text = "рекорды";
            this.BtnRecords.UseVisualStyleBackColor = true;
            this.BtnRecords.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnPlay.BackgroundImage = global::Kursach.Properties.Resources.cosmos_21;
            this.BtnPlay.Location = new System.Drawing.Point(490, 50);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(320, 90);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.button2_Click);
            this.BtnPlay.MouseEnter += new System.EventHandler(this.BtnPlay_MouseEnter);
            this.BtnPlay.MouseLeave += new System.EventHandler(this.BtnPlay_MouseLeave);
            // 
            // BtnRules
            // 
            this.BtnRules.Location = new System.Drawing.Point(490, 270);
            this.BtnRules.Name = "BtnRules";
            this.BtnRules.Size = new System.Drawing.Size(320, 90);
            this.BtnRules.TabIndex = 2;
            this.BtnRules.Text = "правила";
            this.BtnRules.UseVisualStyleBackColor = true;
            this.BtnRules.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(490, 380);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(320, 90);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
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

