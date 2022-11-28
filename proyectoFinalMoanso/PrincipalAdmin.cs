using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalMoanso
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void BtnListarComrpobante_Click(object sender, EventArgs e)
        {
            listaClientes lc = new listaClientes();
            lc.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MantenedorStock m = new MantenedorStock();
            m.Visible= true;
        }

        private void btnListarComprobante_Click(object sender, EventArgs e)
        {
            ListaComprobantes lc = new ListaComprobantes();
            lc.Visible= true;
            
        }
    }
}
