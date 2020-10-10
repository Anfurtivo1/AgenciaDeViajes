using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Stop();
            rbtnMediaPension frmPrincipal = new rbtnMediaPension();
            frmPrincipal.Show();
            this.Hide();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmrTimer.Start();
        }
    }
}
