using System;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class frmPrecios : Form
    {
        public double personas;
        public frmPrecios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            personas=Convert.ToDouble(txbPersonas.Text.ToString());
            this.Visible = false;
            
        }
    }
}
