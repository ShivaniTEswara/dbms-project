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
    }
}
