using System;
using System.Drawing;
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
            timer1.Start();
            pbMontana.Hide();
            pbCiudad.Hide();
            pbPlaya.Hide();
            pbTour.Hide();

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
            double precioP=0;
            double personas;
            String personasP;
            double total=0;
            string aux = "";
            double aux2=0;
            personas = Convert.ToDouble(numudPersonas.Value);
            personasP = f.txbPersonas.Text;
            if (personasP!="")
            {
                precioP = Double.Parse(personasP);
                total = total + precioP;
            }
            

            for (int i = 0; i <tsprbBarraProgreso.Maximum; i++)
            {
                tsprbBarraProgreso.Value = 1 + tsprbBarraProgreso.Value;
                Thread.Sleep(10);
            }
                txbCalculos.AppendText("Destino:");
            if (lbDestinos.SelectedItems[0].ToString().Equals("Ciudad"))
            {
                txbCalculos.AppendText(lbDestinos.SelectedItems[0].ToString()+":");
                txbCalculos.AppendText(f.txbCiudad.Text);
                aux = (f.txbCiudad.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (lbDestinos.SelectedItems[0].ToString().Equals("Playa"))
            {
                txbCalculos.AppendText(lbDestinos.SelectedItems[0].ToString() + ":");
                txbCalculos.AppendText(f.txbPlaya.Text);
                aux = (f.txbPlaya.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (lbDestinos.SelectedItems[0].ToString().Equals("Montaña"))
            {
                txbCalculos.AppendText(lbDestinos.SelectedItems[0].ToString() + ":");
                txbCalculos.AppendText(f.txbMontaña.Text);
                aux = (f.txbMontaña.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (lbDestinos.SelectedItems[0].ToString().Equals("Tour"))
            {
                txbCalculos.AppendText(lbDestinos.SelectedItems[0].ToString() + ":");
                txbCalculos.AppendText(f.txbTour.Text);
                aux = (f.txbTour.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            txbCalculos.AppendText(Environment.NewLine);

            if (rbtnSoloDormir.Checked)
            {
                txbCalculos.AppendText("Estancia: solo dormir:");
                txbCalculos.AppendText(f.txbDormir.Text);
                aux = (f.txbDormir.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
                txbCalculos.AppendText(Environment.NewLine);

            }

            if (rbtnMediaPension.Checked)
            {
                txbCalculos.AppendText("Estancia: media pension:");
                txbCalculos.AppendText(f.txbMedia.Text);
                aux = (f.txbMedia.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
                txbCalculos.AppendText(Environment.NewLine);

            }

            if (rbtnPensionCompleta.Checked)
            {
                txbCalculos.AppendText("Estancia: pension completa:");
                txbCalculos.AppendText(f.txbCompleta.Text);
                aux = (f.txbCompleta.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
                txbCalculos.AppendText(Environment.NewLine);

            }

            txbCalculos.AppendText("Nº de Personas: ");
            txbCalculos.AppendText(""+personas* aux2);
            txbCalculos.AppendText(Environment.NewLine);
            aux = (f.txbCompleta.Text);
            aux2 = Double.Parse(aux);
            total = total + aux2;
            txbCalculos.AppendText("Hotel *s: "+numudEstrellas.Value.ToString()+ ":");
            if (numudEstrellas.Value==1)
            {
                txbCalculos.AppendText(f.txbUnaEstrella.Text);
                aux = (f.txbUnaEstrella.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (numudEstrellas.Value == 2)
            {
                txbCalculos.AppendText(f.txbDosEstrella.Text);
                aux = (f.txbDosEstrella.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (numudEstrellas.Value == 3)
            {
                txbCalculos.AppendText(f.txbTresEstrella.Text);
                aux = (f.txbCompleta.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (numudEstrellas.Value == 4)
            {
                txbCalculos.AppendText(f.txbCuatroEstrella.Text);
                aux = (f.txbCuatroEstrella.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }

            if (numudEstrellas.Value == 5)
            {
                txbCalculos.AppendText(f.txbCincoEstrella.Text);
                aux = (f.txbCompleta.Text);
                aux2 = Double.Parse(aux);
                total = total + aux2;
            }
            txbCalculos.AppendText(Environment.NewLine);

            for (int i = 0; i < chlbActividadesExtras.CheckedItems.Count; i++)
            {
                txbCalculos.AppendText(chlbActividadesExtras.CheckedItems[i].ToString()+": ");
                
                switch (i)
                {
                    case 0:
                        txbCalculos.AppendText(f.txbCenaEspectaculo.Text);
                        aux = (f.txbCenaEspectaculo.Text);
                        aux2 = Double.Parse(aux);
                        total = total + aux2;
                        txbCalculos.AppendText(Environment.NewLine);
                        break;

                    case 1:
                        txbCalculos.AppendText(f.txbExcursionSitios.Text);
                        aux = (f.txbExcursionSitios.Text);
                        aux2 = Double.Parse(aux);
                        total = total + aux2;
                        txbCalculos.AppendText(Environment.NewLine);
                        break;

                    case 2:
                        txbCalculos.AppendText(f.txbLavanderia.Text);
                        aux = (f.txbLavanderia.Text);
                        aux2 = Double.Parse(aux);
                        total = total + aux2;
                        txbCalculos.AppendText(Environment.NewLine);
                        break;
                    case 3:
                        txbCalculos.AppendText(f.txbNaturAventura.Text);
                        aux = (f.txbNaturAventura.Text);
                        aux2 = Double.Parse(aux);
                        total = total + aux2;
                        txbCalculos.AppendText(Environment.NewLine);
                        break;
                    case 4:
                        txbCalculos.AppendText(f.txbSpa.Text);
                        aux = (f.txbSpa.Text);
                        aux2 = Double.Parse(aux);
                        total = total + aux2;
                        txbCalculos.AppendText(Environment.NewLine);
                        break;

                }

            }

            txbCalculos.AppendText(Environment.NewLine);
            txbCantidadTotal.Text = ""+total;
        }

        private void frmFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlFechaHora.Text = DateTime.Now.ToString();
        }

        private void lbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDestinos.SelectedItem == "Montaña")
            {
                pbMontana.Show();
                pbCiudad.Hide();
                pbPlaya.Hide();
                pbTour.Hide();

            }
            else if (lbDestinos.SelectedItem == "Playa")
            {
                pbCiudad.Hide();
                pbMontana.Hide();
                pbPlaya.Show();
                pbTour.Hide();
            }
            else if (lbDestinos.SelectedItem == "Ciudad")
            {
                pbCiudad.Show();
                pbMontana.Hide();
                pbPlaya.Hide();
                pbTour.Hide();
            }
            else if (lbDestinos.SelectedItem == "Tour")
            {
                pbCiudad.Hide();
                pbMontana.Hide();
                pbPlaya.Hide();
                pbTour.Show();
            }
        }
    }
}
