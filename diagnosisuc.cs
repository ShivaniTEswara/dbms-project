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
    public partial class diagnosisuc : UserControl
    {
        private static diagnosisuc _instance;

        public static diagnosisuc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new diagnosisuc();
                }
                return _instance;
            }
        }
        public diagnosisuc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DIAG_ID, CATEGORY FROM DIAGNOSIS ORDER BY DIAG_ID", con);


                //cmd.CommandType = CommandType.StoredProcedure;

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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DIAG_ID, CATEGORY FROM DIAGNOSIS WHERE DIAG_ID=@DIAG_ID ", con);

                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DIAG_ID", searchtb.Text);

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

        private void addbutton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into DIAGNOSIS(DIAG_ID,CATEGORY) values (@DIAG_ID,@CATEGORY)", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DIAG_ID", pssntb.Text);
            cmd.Parameters.AddWithValue("@CATEGORY", nametb.Text);
           
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("      <<<INVALID SQL QUERY>>>     \n" + ex);

            }
            con.Close();
            refresh_dgv();

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DIAGNOSIS SET CATEGORY=@CATEGORY WHERE DIAG_ID=@DIAG_ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                // SqlCommand cmd = new SqlCommand("ptupdate", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DIAG_ID", pssntb.Text);
                cmd.Parameters.AddWithValue("@CATEGORY", nametb.Text);




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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from DIAGNOSIS WHERE DIAG_ID=@DIAG_ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DIAG_ID", pssntb.Text);


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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void diagnosisuc_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            searchtb.Text = "";
            pssntb.Text = "";
            nametb.Text = "";
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

