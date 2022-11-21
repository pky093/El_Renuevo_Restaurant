namespace proyectoFinalMoanso
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MostrarHora = new System.Windows.Forms.Label();
            this.horaActual = new System.Windows.Forms.Timer(this.components);
            this.btnMozo = new System.Windows.Forms.PictureBox();
            this.btnAdministrador = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMozo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MostrarHora);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 522);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnMozo);
            this.panel3.Controls.Add(this.btnAdministrador);
            this.panel3.Location = new System.Drawing.Point(476, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 285);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elige una opción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(25, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MostrarHora
            // 
            this.MostrarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarHora.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MostrarHora.Location = new System.Drawing.Point(154, 394);
            this.MostrarHora.Name = "MostrarHora";
            this.MostrarHora.Size = new System.Drawing.Size(267, 68);
            this.MostrarHora.TabIndex = 2;
            this.MostrarHora.Text = "00:00:00";
            this.MostrarHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horaActual
            // 
            this.horaActual.Enabled = true;
            this.horaActual.Tick += new System.EventHandler(this.horaActual_Tick);
            // 
            // btnMozo
            // 
            this.btnMozo.Image = global::proyectoFinalMoanso.Properties.Resources.mozo;
            this.btnMozo.Location = new System.Drawing.Point(253, 123);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(173, 111);
            this.btnMozo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMozo.TabIndex = 1;
            this.btnMozo.TabStop = false;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Image = global::proyectoFinalMoanso.Properties.Resources.admin2;
            this.btnAdministrador.Location = new System.Drawing.Point(34, 123);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(173, 127);
            this.btnAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdministrador.TabIndex = 0;
            this.btnAdministrador.TabStop = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // logo
            // 
            this.logo.Image = global::proyectoFinalMoanso.Properties.Resources.logotipo;
            this.logo.Location = new System.Drawing.Point(35, 17);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(368, 364);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(890, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(48, 24);
            this.btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn.TabIndex = 4;
            this.btn.TabStop = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::proyectoFinalMoanso.Properties.Resources.exis;
            this.btnCerrar.Location = new System.Drawing.Point(944, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(48, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(995, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMozo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label MostrarHora;
        private System.Windows.Forms.Timer horaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnAdministrador;
        private System.Windows.Forms.PictureBox btnMozo;
        private System.Windows.Forms.Label label2;
    }
}

