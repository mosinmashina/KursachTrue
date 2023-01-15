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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Return_MouseEnter(object sender, EventArgs e)
        {
            this.Return.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\ret2.jpg");
        }

        private void Return_MouseLeave(object sender, EventArgs e)
        {
            this.Return.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_iKcNQWXA7r;
        }
    }
}
