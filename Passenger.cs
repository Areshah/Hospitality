﻿using System;
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
    public partial class Passenger : Form
    {
        Initial ss = new Initial();
        public Passenger()
        {
            InitializeComponent();
            ss.BckColor(this);
        }
    }
}
