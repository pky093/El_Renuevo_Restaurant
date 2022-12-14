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
    public partial class Administrador : Form
    {
        public Administrador()
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


        private void btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void checkcontra_CheckedChanged(object sender, EventArgs e)
        {
            if(checkcontra.Checked)
            {
                cajacontra.UseSystemPasswordChar = true;
            }
            else
            {
                cajacontra.UseSystemPasswordChar = false;
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (cajausuario.Text == "1" && cajacontra.Text == "1")
            {
                PrincipalAdmin pa = new PrincipalAdmin();
                pa.Visible= true;
                Dispose();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta, verificalo nuevamente");
                cajausuario.Text = string.Empty;
                cajacontra.Text = string.Empty;
            }
        }
    }
}
