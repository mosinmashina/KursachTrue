
namespace Kursach
{
    partial class InfoForm
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
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_iKcNQWXA7r;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Location = new System.Drawing.Point(31, 948);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(320, 90);
            this.Return.TabIndex = 0;
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            this.Return.MouseEnter += new System.EventHandler(this.Return_MouseEnter);
            this.Return.MouseLeave += new System.EventHandler(this.Return_MouseLeave);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Kursach.Properties.Resources.fotor_2023_1_15_3_54_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1080);
            this.Controls.Add(this.Return);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
    }
}