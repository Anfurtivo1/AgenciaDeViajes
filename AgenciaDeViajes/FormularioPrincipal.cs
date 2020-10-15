using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class frmFormularioPrincipal : Form
    {
        public frmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private void frmFormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmFormularioPrincipal_Activated(object sender, EventArgs e)
        {
                stlFechaHora.Text = DateTime.Now.ToString();
            
        }

        private void btnAcuerdoEmpresa_Click(object sender, EventArgs e)
        {
            frmAcuerdo acuerdo = new frmAcuerdo();
            acuerdo.ShowDialog();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            frmPrecios precios = new frmPrecios();
            precios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <tsprbBarraProgreso.Maximum; i++)
            {
                tsprbBarraProgreso.Value = 1 + tsprbBarraProgreso.Value;
                Thread.Sleep(10);
            }

            if (true)
            {

            }

            if (true)
            {

            }

            if (true)
            {

            }

            if (true)
            {

            }

            if (rbtnSoloDormir.Checked)
            {
                txbCalculos.AppendText("Estancia: solo dormir:");
                txbCalculos.AppendText(" ");
            }

            if (rbtnMediaPension.Checked)
            {
                txbCalculos.AppendText("Estancia: media pension:");
                txbCalculos.AppendText(" ");
            }

            if (rbtnPensionCompleta.Checked)
            {
                txbCalculos.AppendText("Estancia: pension completa:");
                txbCalculos.AppendText(" ");
            }

            txbCalculos.AppendText("Nº de Personas: "+numudPersonas.Value.ToString());
            txbCalculos.AppendText(" ");
            txbCalculos.AppendText("Hotel *s: "+numudEstrellas.Value.ToString());
            txbCalculos.AppendText(" ");



        }
    }
}
