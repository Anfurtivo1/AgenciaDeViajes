using System;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class frmPrecios : Form
    {
        public frmPrecios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}
