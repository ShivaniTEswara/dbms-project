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
    }
}
