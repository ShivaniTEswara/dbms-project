using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medico
{
    public partial class billuc : UserControl
    {
        private static billuc _instance;

        public static billuc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new billuc();
                }
                return _instance;
            }
        }
        public billuc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            String syntax = "INSERT INTO BILL  (BILL_NO,P_SSN,AMOUNT,BILL_DATE) values (@BILL_NO, @P_SSN, @AMOUNT, @BILL_DATE)";
            SqlCommand cmd = new SqlCommand(syntax, con);
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@P_SSN", pssntb.Text);
            cmd.Parameters.AddWithValue("@BILL_NO", billnotb.Text);
            cmd.Parameters.AddWithValue("@AMOUNT", textBox2.Text);
            cmd.Parameters.AddWithValue("@BILL_DATE", dateTimePicker1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("      <<<INVALID SQL QUERY>>>     \n" + ex);

            }
            con.Close();
            
            //refresh_dgv();

        }

        private void homebutton_Click(object sender, EventArgs e)
        {
           /* Home home = new Home();
            this.Hide();
            home.Show();*/
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(billdata.Instance))
            {
                panel1.Controls.Add(billdata.Instance);
                billdata.Instance.Dock = DockStyle.Fill;
                billdata.Instance.BringToFront();
            }
            else
            {
                billdata.Instance.BringToFront();
            }
        }
    }
}
