﻿using System;
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
    public partial class prescriptionuc : UserControl
    {
        private static prescriptionuc _instance;

        public static prescriptionuc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new prescriptionuc();
                }
                return _instance;
            }
        }
        public prescriptionuc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT P.PRES_ID, P.M_QTY, P1.P_SSN FROM PATIENT P1, PRESCRIPTION P  WHERE P.P_SSN = P1.P_SSN ORDER BY P.PRES_ID", con);


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

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into PRESCRIPTION(PRES_ID,M_QTY,P_SSN) values (@PRES_ID,@M_QTY,@P_SSN)", con);
           //cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PRES_ID", pssntb.Text);
            cmd.Parameters.AddWithValue("@M_QTY", nametb.Text);
            cmd.Parameters.AddWithValue("@P_SSN", phnotb.Text);

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
                SqlCommand cmd = new SqlCommand("UPDATE PRESCRIPTION SET P_SSN=@P_SSN, M_QTY=@M_QTY  WHERE PRES_ID=@PRES_ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

               // SqlCommand cmd = new SqlCommand("ptupdate", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PRES_ID", pssntb.Text);
                cmd.Parameters.AddWithValue("@M_QTY", nametb.Text);
                cmd.Parameters.AddWithValue("@P_SSN", phnotb.Text);




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

        private void prescriptionuc_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from PRESCRIPTION WHERE PRES_ID=@PRES_ID", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PRES_ID", pssntb.Text);


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
            phnotb.Text = "";
           
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT P.PRES_ID, P.M_QTY, P1.P_SSN FROM PRESCRIPTION P, PATIENT P1 WHERE P.P_SSN = P1.P_SSN AND P.PRES_ID=@PRES_ID ", con);

                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRES_ID", searchtb.Text);

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}
