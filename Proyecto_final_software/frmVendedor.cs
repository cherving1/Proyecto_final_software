using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_software
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from V in ventas.Vendedor
                           select V;
            dgvVendedor.DataSource = consulta;
        }
        private void frmVendedor_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
