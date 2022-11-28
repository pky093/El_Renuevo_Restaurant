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
    public partial class ComprantePago : Form
    {
        public ComprantePago( int idcliente,int idpedido,float monto, string fecha,string tipoPago)
        {
            InitializeComponent();
            lidcli.Text = idcliente.ToString();
            ldpe.Text = idpedido.ToString();
            lmonto.Text = monto.ToString();
            ltFecha.Text = fecha;
            Lmp.Text = tipoPago;
        }
    }
}
