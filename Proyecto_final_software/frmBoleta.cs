using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_software
{
    public partial class frmBoleta : Form
    {
        public frmBoleta()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from B in ventas.Boleta
                           select B;
            dgvBoleta.DataSource = consulta;
        }
        private void Codigo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnulado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgvBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
