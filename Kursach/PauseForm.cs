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
    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
        }

        private void PauseForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((PlayForm)Owner).isPause = false;
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainForm = Owner.Owner;
            Owner.Close();
            mainForm.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\back2.jpg");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_e2A3uOyMZO9xH__1_;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\exit2_3.jpg");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_QcgXPJBZ3374;
        }
    }
}
