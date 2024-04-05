using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Controllers;

namespace Kursach
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            NamesAndRecords nameAndRecords = Records.getRecords();
            for (int i = 0; i < nameAndRecords.scores.Count; i++)
                this.textBox1.Text += (i+1).ToString() + ". " + nameAndRecords.names[i] + ' ' + nameAndRecords.scores[i].ToString() + "\r" + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void RecordsForm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\ret2.jpg");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::Kursach.Properties.Resources.imgonline_com_ua_Resize_iKcNQWXA7r;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
