using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLAoQuan
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void mnu_dn_Click(object sender, EventArgs e)
        {
            QLHT qlht = new QLHT();
            qlht.Show();
        }

        private void mnu_out_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
