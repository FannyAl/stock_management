using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_menu
{
    public partial class frm_mdi_page : Form
    {
        public frm_mdi_page()
        {
            InitializeComponent();
        }

        private void frm_mdi_page_Load(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            f.MdiParent = this;
            f.Show();
        }
    }
}
