using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trouism
{
    public partial class Plane : Form
    {
        Initial ss = new Initial();
        public Plane()
        {
            InitializeComponent();
            ss.BckColor(this);
        }
    }
}
