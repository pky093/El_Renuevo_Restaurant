using CapaLogica;
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
        MantenedorPedidos mp;
        MantenedorMetodosPago fm;



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

                mc = new MantenedorCliente(" ", " "," ");
                mc.Visible = true;

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            
            if (mc == null)
            {
                MessageBox.Show("primero debe registrar al cliente");
               
            }
            else {

                mp = new MantenedorPedidos(mc.retornarIDcliente());
                if (mc.retornarIDcliente() == " ")
                {
                    MessageBox.Show("se tiene primero que registrar al cliente");
                   

                }
                else
                {
                    mp.Visible = true;
                }
                
            }


        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

            if (mp == null)
            {
                MessageBox.Show("primero debe registrar al cliente");
                
            }
            else
            {
                fm = new MantenedorMetodosPago(mc.retornarNombre(), mc.retornarApellido(), mp.returnPago(),mp.retornarFechaPedido(),mc.retornarIDcliente());
                if (mc.retornarIDcliente() == " ")
                {
                    MessageBox.Show("se tiene primero que registrar al cliente");

                }
                else
                {
                    fm.Visible = true;
                }
            }
                
        }
    }
}
