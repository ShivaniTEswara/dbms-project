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
    public partial class patientuc : UserControl
    {
        private static patientuc _instance;

        public static patientuc Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new patientuc();
                }
                return _instance;
            }
        }
        public patientuc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showptdata", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION>>>     " + ex);
                }
                con.Close();

                dataGridView2.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("patientadd", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@P_SSN", pssntb.Text);
            cmd.Parameters.AddWithValue("@D_SSN", dssncb.Text);
            cmd.Parameters.AddWithValue("@PNAME", nametb.Text);
            cmd.Parameters.AddWithValue("@AGE", agetb.Text);
            cmd.Parameters.AddWithValue("@PH_NO", phnotb.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", addtb.Text);
            cmd.Parameters.AddWithValue("@GENDER", gendertb.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("      <<<INVALID SQL QUERY>>>     \n" + ex);

            }
            con.Close();
            refresh_dgv();

        }

        private void patientuc_Load(object sender, EventArgs e)
        {
            refresh_dgv();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ptdelete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_SSN", pssntb.Text);
                

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION>>>     \n" + ex);

                }
                con.Close();
                refresh_dgv();

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ptsearch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_SSN", searchtb.Text);

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

                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            searchtb.Text = "";
            pssntb.Text = "";
            dssncb.Text = "";
            nametb.Text = "";
            agetb.Text = "";
            gendertb.Text = "";
            phnotb.Text = "";
            addtb.Text = "";
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PATIENT SET D_SSN=@D_SSN, PNAME=@PNAME, AGE=@AGE, ADDRESS=@ADDRESS, PH_NO=@PH_NO, GENDER=@GENDER WHERE P_SSN=@P_SSN", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P_SSN", pssntb.Text);
                cmd.Parameters.AddWithValue("@D_SSN", dssncb.Text);
                cmd.Parameters.AddWithValue("@PNAME", nametb.Text);
                cmd.Parameters.AddWithValue("@AGE", agetb.Text);
                cmd.Parameters.AddWithValue("@PH_NO", phnotb.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", addtb.Text);
                cmd.Parameters.AddWithValue("@GENDER", gendertb.Text);


              
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION>>>     \n" + ex);

                }
                con.Close();
                refresh_dgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dssncb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
