using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medico
{
    public partial class Home : Form
    {
        bool ispmenuopen = false;
        bool ispmenuopen1 = false;
        public Home()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (label1.Text == "P1")
            {
                pictureBox1.Image = Properties.Resources.pic3;
                label1.Text = "P2";
            }
            else if (label1.Text == "P2")
            {
                pictureBox1.Image = Properties.Resources.pic4;
                label1.Text = "P3";
            }
            else if (label1.Text == "P3")
            {
                pictureBox1.Image = Properties.Resources.pic2;
                label1.Text = "P4";
            }
            else if (label1.Text == "P4")
            {
                pictureBox1.Image = Properties.Resources.pic1;
                label1.Text = "P1";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       private void button4_Click(object sender, EventArgs e)
        {
            //timer3.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(ispmenuopen == true)
            {
                panel2.Height -= 115;
                if (panel2.Height == 0)
                {
                    timer2.Stop();
                    ispmenuopen = false;
                }
            }
            else if(ispmenuopen == false)
            {
                panel2.Height += 115;
                if (panel2.Height == 115)
                {
                    timer2.Stop();
                    ispmenuopen = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (ispmenuopen1 == true)
            {
                panel1.Height -= 179;
                if (panel1.Height == 0)
                {
                    timer3.Stop();
                    ispmenuopen1 = false;
                }
            }
            else if (ispmenuopen1 == false)
            {
                panel1.Height += 179;
                if (panel1.Height == 179)
                {
                    timer3.Stop();
                    ispmenuopen1 = true;
                }
            }
            }

        private void label7_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DOCTOR_INFO di = new DOCTOR_INFO();
            this.Hide();
            di.Show();
        }
        /* private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
{

}*/
    }
}
