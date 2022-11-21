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
    public partial class MantenedorPedidos : Form
    {
        
        public MantenedorPedidos(string nombre)
        {
            InitializeComponent();
            labelNombre.Text = nombre;
        }
    }
}
