using System;
using System.Threading;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class frmFormularioPrincipal : Form
    {
        public frmPrecios f = new frmPrecios();
        public frmFormularioPrincipal()
        {
            InitializeComponent();
            
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
            f.ShowDialog();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tsprbBarraProgreso.Value =0;
            frmPrecios precios = new frmPrecios();
            double personas=0;
            personas = (double)numudPersonas.Value;



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
                txbCalculos.AppendText(precios.txbDormir.Text);
                txbCalculos.AppendText(" ");
                
            }

            if (rbtnMediaPension.Checked)
            {
                txbCalculos.AppendText("Estancia: media pension:");
                txbCalculos.AppendText(precios.txbMedia.Text);
                txbCalculos.AppendText(" ");
                
            }

            if (rbtnPensionCompleta.Checked)
            {
                txbCalculos.AppendText("Estancia: pension completa:");
                txbCalculos.AppendText(precios.txbCompleta.Text);
                txbCalculos.AppendText(" ");
                
            }

            txbCalculos.AppendText("Nº de Personas: "+numudPersonas.Value.ToString());
            txbCalculos.AppendText(""+personas*precios.personas);
            txbCalculos.AppendText(" ");
            txbCalculos.AppendText("Hotel *s: "+numudEstrellas.Value.ToString());
            txbCalculos.AppendText(" ");

            for (int i = 0; i < chlbActividadesExtras.CheckedItems.Count; i++)
            {
                txbCalculos.AppendText(chlbActividadesExtras.CheckedItems[i].ToString()+": ");
            }

            txbCalculos.AppendText(mncCalendarioFecha.SelectionRange.ToString());



        }

        private void frmFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
