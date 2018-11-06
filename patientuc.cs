using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
