namespace proyectoFinalMoanso
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ingresar = new System.Windows.Forms.Button();
            this.checkcontra = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contrasena = new System.Windows.Forms.Label();
            this.cajacontra = new System.Windows.Forms.TextBox();
            this.cajausuario = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 27);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Administrador";
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(444, 2);
            this.btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(36, 20);
            this.btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn.TabIndex = 4;
            this.btn.TabStop = false;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::proyectoFinalMoanso.Properties.Resources.exis;
            this.btnCerrar.Location = new System.Drawing.Point(484, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Ingresar);
            this.panel2.Controls.Add(this.checkcontra);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.contrasena);
            this.panel2.Controls.Add(this.cajacontra);
            this.panel2.Controls.Add(this.cajausuario);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 404);
            this.panel2.TabIndex = 2;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(18)))));
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(184, 326);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(164, 50);
            this.Ingresar.TabIndex = 13;
            this.Ingresar.Text = "INICIAR SESIÓN";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // checkcontra
            // 
            this.checkcontra.AutoSize = true;
            this.checkcontra.Location = new System.Drawing.Point(373, 268);
            this.checkcontra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkcontra.Name = "checkcontra";
            this.checkcontra.Size = new System.Drawing.Size(118, 17);
            this.checkcontra.TabIndex = 12;
            this.checkcontra.Text = "Mostrar Contraseña";
            this.checkcontra.UseVisualStyleBackColor = true;
            this.checkcontra.CheckedChanged += new System.EventHandler(this.checkcontra_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoFinalMoanso.Properties.Resources.admin21;
            this.pictureBox1.Location = new System.Drawing.Point(184, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(40, 262);
            this.contrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(136, 26);
            this.contrasena.TabIndex = 10;
            this.contrasena.Text = "contraseña:";
            // 
            // cajacontra
            // 
            this.cajacontra.Location = new System.Drawing.Point(184, 266);
            this.cajacontra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cajacontra.Multiline = true;
            this.cajacontra.Name = "cajacontra";
            this.cajacontra.PasswordChar = '*';
            this.cajacontra.Size = new System.Drawing.Size(164, 22);
            this.cajacontra.TabIndex = 9;
            // 
            // cajausuario
            // 
            this.cajausuario.Location = new System.Drawing.Point(184, 212);
            this.cajausuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cajausuario.Multiline = true;
            this.cajausuario.Name = "cajausuario";
            this.cajausuario.Size = new System.Drawing.Size(164, 22);
            this.cajausuario.TabIndex = 6;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(75, 207);
            this.usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(101, 26);
            this.usuario.TabIndex = 5;
            this.usuario.Text = "Usuario:";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cajausuario;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox cajacontra;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkcontra;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label label3;
    }
}