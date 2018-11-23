using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            con.Open();
            String syntax = "SELECT DNAME FROM DOCTOR where D_SSN='D100'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
            

        }

        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT D_SSN FROM DOCTOR where DNAME='PROMED'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
             

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            String uname=getUserName(),upass=getPassword(),name,pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(uname) && pass.Equals(upass))
            {
                //MessageBox.Show("Log in Successful");
                PInfo pi = new PInfo();
                this.Hide();
                pi.Show();
            }
            else
            {
                MessageBox.Show("Credentials entered is wrong");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
