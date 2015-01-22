using kopirovac_suborov.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopirovac_suborov
{
    public partial class OknoOPrograme : Form
    {
        public OknoOPrograme()
        {
            InitializeComponent();
            
        }

        private void btnOProgrameOk_Click(object sender, EventArgs e)
        {
            Program.oknoMain.Enabled = true;
            Program.okno.Dispose();
        }

        private void OknoOPrograme_Load(object sender, EventArgs e)
        {

        }

        
    }
}
