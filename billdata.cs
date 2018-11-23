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
    public partial class billdata : UserControl
    {
        private static billdata _instance;

        public static billdata Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new billdata();
                }
                return _instance;

            }
        }
        public billdata()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public void refresh_dgv()
        {
            try
            {
                String syntax = "SELECT B.BILL_NO,P.P_SSN,B.AMOUNT,B.BILL_DATE FROM BILL B, PATIENT P WHERE P.P_SSN=B.P_SSN ";
                SqlCommand cmd = new SqlCommand(syntax, con);
               // cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION>>>     " + ex);
                }
                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void billdata_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            billuc bill = new billuc();
            this.Hide();
            bill.Show();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
