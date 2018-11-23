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
    public partial class medicine : UserControl
    {
        private static medicine _instance;

        public static medicine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new medicine();
                }
                return _instance;
            }
        }
        public medicine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT M.ID,P.PRES_ID,M.MNAME, M.MED_QTYDAY, M.NO_OF_DAYS FROM MEDICINE M, PRESCRIPTION P  WHERE M.PRES_ID=P.PRES_ID ORDER BY M.ID", con);
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



        private void agetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT M.ID, P.PRES_ID, M.MNAME, M.MED_QTYDAY, M.NO_OF_DAYS FROM PRESCRIPTION P, MEDICINE M WHERE P.PRES_ID = M.PRES_ID AND M.ID=@ID", con);
               //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", searchtb.Text);

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

        private void medicine_Load(object sender, EventArgs e)
        {
            refresh_dgv();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into MEDICINE(ID,PRES_ID,MNAME,MED_QTYDAY,NO_OF_DAYS) values (@ID,@PRES_ID,@MNAME,@MED_QTYDAY,@NO_OF_DAYS)", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", pssntb.Text);
            cmd.Parameters.AddWithValue("@PRES_ID", nametb.Text);
            cmd.Parameters.AddWithValue("@MNAME", agetb.Text);
            cmd.Parameters.AddWithValue("@MED_QTYDAY", phnotb.Text);
            cmd.Parameters.AddWithValue("@NO_OF_DAYS", addtb.Text);

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
                //SqlCommand cmd = new SqlCommand("UPDATE PATIENT SET D_SSN=@D_SSN, PNAME=@PNAME, AGE=@AGE, ADDRESS=@ADDRESS, PH_NO=@PH_NO, GENDER=@GENDER WHERE P_SSN=@P_SSN", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                SqlCommand cmd = new SqlCommand("UPDATE MEDICINE SET PRES_ID=@PRES_ID, MED_QTYDAY=@MED_QTYDAY,NO_OF_DAYS=@NO_OF_DAYS  WHERE ID=@ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", pssntb.Text);
                cmd.Parameters.AddWithValue("@PRES_ID", nametb.Text);
                cmd.Parameters.AddWithValue("@MNAME", agetb.Text);
                cmd.Parameters.AddWithValue("@MED_QTYDAY", phnotb.Text);
                cmd.Parameters.AddWithValue("@NO_OF_DAYS", addtb.Text);




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
                SqlCommand cmd = new SqlCommand("delete from MEDICINE WHERE ID=@ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", pssntb.Text);


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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            searchtb.Text = "";
            pssntb.Text = "";
            nametb.Text = "";
            agetb.Text = "";
            phnotb.Text = "";
            addtb.Text = "";

        }
    }
}
