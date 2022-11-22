using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalMoanso
{
    public partial class Mozo : Form
    {
        MantenedorCliente mc;
        bool cliente = false;

        public Mozo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaMozo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (cliente == false)
            {
                mc = new MantenedorCliente(" ", " ");
                mc.Visible = true;
                cliente = true;
            }

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (cliente == true)
            {
                MantenedorPedidos mp = new MantenedorPedidos(mc.retornarNombre());
                mp.Visible = true;
                
            }
            else
            {
                MessageBox.Show("se tiene que registrar al cliente");
            }


        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if (cliente == true)
            {
                FormasPago fm = new FormasPago(mc.retornarNombre(), mc.retornarApellido());
                fm.Visible = true;
                
            }
            else
            {
                MessageBox.Show("se tiene que registrar al cliente");
            }
        }
    }
}
