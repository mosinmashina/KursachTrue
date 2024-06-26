﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kursach
{
    public partial class Menu : Form
    {
        InfoForm infoForm = new InfoForm();
        PlayForm playForm;
        bool gameIsOpen;
        bool gameIsClose;
        public Menu()
        {
            InitializeComponent();
            infoForm.Owner = this;
            gameIsClose = false;
            gameIsOpen = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameIsOpen = true;
            playForm = new PlayForm();
            playForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            infoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlay_MouseEnter(object sender, EventArgs e)
        {
            BtnPlay.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\play2.jpg");
        }

        private void BtnPlay_MouseLeave(object sender, EventArgs e)
        {
            BtnPlay.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_b1qreUGNPLCxgdA;
        }

        private void Menu_Activated(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        private void BtnRecords_MouseEnter(object sender, EventArgs e)
        {
            BtnRecords.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\rec2.jpg");
        }

        private void BtnRecords_MouseLeave(object sender, EventArgs e)
        {
            BtnRecords.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_5fNLONJPbu9B;
        }

        private void BtnRules_MouseEnter(object sender, EventArgs e)
        {
            BtnRules.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\rul2.jpg");
        }

        private void BtnRules_MouseLeave(object sender, EventArgs e)
        {
            BtnRules.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_cf91T8gwoxee5mM;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\exit2.jpg");
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_GPzpH18bVujQeXb;
        }
    }
}
