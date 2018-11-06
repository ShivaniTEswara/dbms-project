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
    public partial class homeuc : UserControl
    {
        private static homeuc _instance;

        public static homeuc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new homeuc();
                }
                return _instance;
            }
        }
        public homeuc()
        {
            InitializeComponent();
        }
    }
}
