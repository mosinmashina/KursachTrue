using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursach
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm playform = new PlayForm();
            playform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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
            BtnRules.Text = "Вошел";
        }

        private void BtnPlay_MouseLeave(object sender, EventArgs e)
        {
            BtnRules.Text = "Уже вышел";
        }

        private void Menu_Activated(object sender, EventArgs e)
        {

        }
    }
}
