﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DatSanCauLong_CS464SE
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void quảnLýSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_QuanLySan"] == null)
            {
                frm_QuanLySan frm = new frm_QuanLySan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            
                Application.OpenForms["frm_QuanLySan"].Activate();
            
        }

        private void đặtSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DatSan"] == null)
            {
                frm_DatSan frm = new frm_DatSan();
                frm.MdiParent = this;
                frm.Show();
            }
            else

                Application.OpenForms["frm_DatSan"].Activate();

        }
    }
}
