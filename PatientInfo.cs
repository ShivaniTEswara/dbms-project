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
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(! contentpanel.Controls.Contains(patientuc.Instance))
            {
                contentpanel.Controls.Add(patientuc.Instance);
                patientuc.Instance.Dock = DockStyle.Fill;
                patientuc.Instance.BringToFront();
            }
            else
            {
                patientuc.Instance.BringToFront();
           
            }
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
