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
    public partial class EndGameForm : Form
    {
        public EndGameForm(int playerScore)
        {
            InitializeComponent();
            this.button3.Text = playerScore.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(((PlayForm)Owner).playerName);
            playForm.Owner = Owner.Owner;
            Owner.Close();
            this.Hide();
            playForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainMenu = Owner.Owner;
            Owner.Close();
            mainMenu.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = 
                new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\newGame2.jpg");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_tgh4zcl0ulSnqv;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\exitFrom2.jpg");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_rWKSaSGSUdnUTETi__1_;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
