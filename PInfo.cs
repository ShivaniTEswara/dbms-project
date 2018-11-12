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
            HomeTabButton.Text = "HOME";
            PatientTabButton.Text = "PATIENT";
            PrescriptionTabButton.Text = "PRESCRIPTION";
            DiagnosisTabButton.Text = "DIAGNOSIS";
            SlidingPanel_ToggleButton.Image = Properties.Resources.larrow;
            SlidingPanel_ToggleButton.ImageAlign = ContentAlignment.MiddleCenter;
            HomeTabButton.Image = null;
            PatientTabButton.Image = null;
            PrescriptionTabButton.Image = null;
            DiagnosisTabButton.Image = null;

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

        }

        private void HomeTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(homeuc.Instance))
            {
                ContentPanel.Controls.Add(homeuc.Instance);
                homeuc.Instance.Dock = DockStyle.Fill;
                homeuc.Instance.BringToFront();
            }
            else
            {
                homeuc.Instance.BringToFront();
            }

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

        
    }
}
