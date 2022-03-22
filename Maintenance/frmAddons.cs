using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trouism.Maintenance
{
    
    public partial class frmAddons : Form
    {
        Initial ss = new Initial();
        public frmAddons()
        {
            InitializeComponent();
            ss.BckColor(this);
        }
    }
}
