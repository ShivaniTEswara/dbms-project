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
    public partial class PInfo : Form
    {
        public PInfo()
        {
            InitializeComponent();

            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();

        }

        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retract
                retractSlidingPanelGUI();
            }
            SlidingPanelTimer.Start();
            //SlidingPanel_ToggleButton.BackgroundImage = null;

        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retract panel
                SlidingPanel.Width -= 50;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                //expand panel
                SlidingPanel.Width += 50;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }

        }
        public void expandSlidingPanelGUI()
        {
            HomeTabButton.Text = "LOG OUT";
            PatientTabButton.Text = "PATIENT";
            PrescriptionTabButton.Text = "PRESCRIPTION";
            DiagnosisTabButton.Text = "DIAGNOSIS";
            medTabButton.Text = "MEDICINE";
            billTabButton.Text = "BILL";
            SlidingPanel_ToggleButton.Image = Properties.Resources.larrow;
            SlidingPanel_ToggleButton.ImageAlign = ContentAlignment.MiddleCenter;
            HomeTabButton.Image = null;
            PatientTabButton.Image = null;
            PrescriptionTabButton.Image = null;
            DiagnosisTabButton.Image = null;
            medTabButton.Image = null;
            billTabButton.Image = null;

        }
        public void retractSlidingPanelGUI()
        {
            HomeTabButton.Text = "";
            PatientTabButton.Text = "";
            PrescriptionTabButton.Text = "";
            DiagnosisTabButton.Text = "";
            SlidingPanel_ToggleButton.Image = Properties.Resources.rarrow;
            SlidingPanel_ToggleButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeTabButton.Image = Properties.Resources.hbut;
            
            PatientTabButton.Image = Properties.Resources.patientbut;
            PrescriptionTabButton.Image = Properties.Resources.presbut;
            DiagnosisTabButton.Image = Properties.Resources.diagbut;
            billTabButton.Image = Properties.Resources.bill;
            medTabButton.Image = Properties.Resources.med;


        }

        private void HomeTabButton_Click(object sender, EventArgs e)
        {
            /*if (!ContentPanel.Controls.Contains(homeuc.Instance))
            {
                ContentPanel.Controls.Add(homeuc.Instance);
                homeuc.Instance.Dock = DockStyle.Fill;
                homeuc.Instance.BringToFront();
            }
            else
            {
                homeuc.Instance.BringToFront();
            }*/
            Home h = new Home();
            this.Hide();
            h.Show();

        }
        

        private void PatientTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(patientuc.Instance))
            {
                ContentPanel.Controls.Add(patientuc.Instance);
                patientuc.Instance.Dock = DockStyle.Fill;
                patientuc.Instance.BringToFront();
            }
            else
            {
                patientuc.Instance.BringToFront();
            }
        }

        private void PrescriptionTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(prescriptionuc.Instance))
            {
                ContentPanel.Controls.Add(prescriptionuc.Instance);
                prescriptionuc.Instance.Dock = DockStyle.Fill;
                prescriptionuc.Instance.BringToFront();
            }
            else
            {
                prescriptionuc.Instance.BringToFront();
            }
        }

        private void DiagnosisTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(diagnosisuc.Instance))
            {
                ContentPanel.Controls.Add(diagnosisuc.Instance);
                diagnosisuc.Instance.Dock = DockStyle.Fill;
                diagnosisuc.Instance.BringToFront();
            }
            else
            {
                diagnosisuc.Instance.BringToFront();
            }
        }

        private void medTabButton_Click(object sender, EventArgs e)
        {
             if (!ContentPanel.Controls.Contains(medicine.Instance))
            {
                ContentPanel.Controls.Add(medicine.Instance);
                medicine.Instance.Dock = DockStyle.Fill;
                medicine.Instance.BringToFront();
            }
            else
            {
                medicine.Instance.BringToFront();
            }
        }

        private void billTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(billuc.Instance))
            {
                ContentPanel.Controls.Add(billuc.Instance);
                billuc.Instance.Dock = DockStyle.Fill;
                billuc.Instance.BringToFront();
            }
            else
            {
                billuc.Instance.BringToFront();
            }
        }
    }
}
