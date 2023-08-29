using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedidasDeDistancia
{
    public partial class frmMedidasDeDistancia : Form
    {

        
        public frmMedidasDeDistancia()
        {
            InitializeComponent();
        }
        

        Medidas objM = new();
       
        private void cboDe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            objM.opcion1 = cboDe.Text;
        }
        

        private void cboA_SelectedIndexChanged(object sender, EventArgs e)
        {
            objM.opcion2 = cboA.Text;
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtCantidad.Focus();
            if (validar() == "")
            {
                if (cboDe.SelectedItem.Equals("Kilometros"))
                {
                    double km;
                    km = double.Parse(txtCantidad.Text);

                    objM.km = km;
                }
                if (cboDe.SelectedItem.Equals("Metros"))
                {
                    double mt;
                    mt = double.Parse(txtCantidad.Text);

                    objM.metros = mt;
                }
                if (cboDe.SelectedItem.Equals("Millas"))
                {
                    double mll;
                    mll = double.Parse(txtCantidad.Text);

                    objM.millas = mll;
                }
                if (cboDe.SelectedItem.Equals("Centimetros"))
                {
                    double cm;
                    cm = double.Parse(txtCantidad.Text);

                    objM.centimetros = cm;


                    txtCantidad.Clear();


                }
            }
            else
            {
                MessageBox.Show($"El error esta en {validar()}");
            }
            txtResultado.Text = objM.Conversion().ToString();
            txtCantidad.Enabled = false;
            btnLimpiar.Focus();
            btnCalcular.Enabled = false;

        }

        private string validar()
        {

            if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "la cantidad, esta vacia";

            }
            else if (int.Parse(txtCantidad.Text) <= 0)
            {
                txtCantidad.Focus();
                return "la cantidad ingresada";

            }
            return "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboA.Text = "Seleccione";
            cboDe.Text = "Selecione";
            txtCantidad.Clear();
            txtResultado.Clear();
            txtCantidad.Focus();
            txtCantidad.Enabled = true;
            btnCalcular.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Esta seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
