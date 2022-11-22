namespace proyectoFinalMoanso
{
    partial class MantenedorMetodosPago
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
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btntarjeta = new System.Windows.Forms.Button();
            this.panelEfectivo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprobantePago = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelEfectivo.SuspendLayout();
            this.panelTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.FlatAppearance.BorderSize = 0;
            this.btnEfectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Image = global::proyectoFinalMoanso.Properties.Resources.dinero_en_efectivo1;
            this.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEfectivo.Location = new System.Drawing.Point(105, 33);
            this.btnEfectivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(197, 72);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.Text = "         Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btntarjeta
            // 
            this.btntarjeta.FlatAppearance.BorderSize = 0;
            this.btntarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.btntarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btntarjeta.Image = global::proyectoFinalMoanso.Properties.Resources.visa;
            this.btntarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntarjeta.Location = new System.Drawing.Point(483, 33);
            this.btntarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntarjeta.Name = "btntarjeta";
            this.btntarjeta.Size = new System.Drawing.Size(197, 72);
            this.btntarjeta.TabIndex = 1;
            this.btntarjeta.Text = "          Tarjeta";
            this.btntarjeta.UseVisualStyleBackColor = true;
            this.btntarjeta.Click += new System.EventHandler(this.btntarjeta_Click);
            // 
            // panelEfectivo
            // 
            this.panelEfectivo.Controls.Add(this.labelTotal);
            this.panelEfectivo.Controls.Add(this.label5);
            this.panelEfectivo.Controls.Add(this.labelApellido);
            this.panelEfectivo.Controls.Add(this.labelNombre);
            this.panelEfectivo.Controls.Add(this.label4);
            this.panelEfectivo.Controls.Add(this.label3);
            this.panelEfectivo.Location = new System.Drawing.Point(19, 137);
            this.panelEfectivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEfectivo.Name = "panelEfectivo";
            this.panelEfectivo.Size = new System.Drawing.Size(372, 274);
            this.panelEfectivo.TabIndex = 2;
            this.panelEfectivo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label5.Location = new System.Drawing.Point(73, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label4.Location = new System.Drawing.Point(43, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label3.Location = new System.Drawing.Point(57, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            this.label3.UseWaitCursor = true;
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.Controls.Add(this.textBox4);
            this.panelTarjeta.Controls.Add(this.label7);
            this.panelTarjeta.Controls.Add(this.textBox3);
            this.panelTarjeta.Controls.Add(this.textBox2);
            this.panelTarjeta.Controls.Add(this.label6);
            this.panelTarjeta.Controls.Add(this.label2);
            this.panelTarjeta.Controls.Add(this.textBox1);
            this.panelTarjeta.Controls.Add(this.label1);
            this.panelTarjeta.Location = new System.Drawing.Point(430, 137);
            this.panelTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(345, 274);
            this.panelTarjeta.TabIndex = 3;
            this.panelTarjeta.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 222);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label7.Location = new System.Drawing.Point(22, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "cv:";
            this.label7.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 167);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label6.Location = new System.Drawing.Point(22, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero:";
            this.label6.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 15.75F);
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "fecha de vencimiento";
            this.label2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Completo";
            this.label1.UseWaitCursor = true;
            // 
            // btnComprobantePago
            // 
            this.btnComprobantePago.FlatAppearance.BorderSize = 0;
            this.btnComprobantePago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.btnComprobantePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobantePago.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantePago.Location = new System.Drawing.Point(165, 426);
            this.btnComprobantePago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprobantePago.Name = "btnComprobantePago";
            this.btnComprobantePago.Size = new System.Drawing.Size(495, 66);
            this.btnComprobantePago.TabIndex = 4;
            this.btnComprobantePago.Text = "Generar Comprobante de pago";
            this.btnComprobantePago.UseVisualStyleBackColor = true;
            this.btnComprobantePago.Visible = false;
            this.btnComprobantePago.Click += new System.EventHandler(this.btnComprobantePago_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(183, 24);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(27, 29);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "n";
            this.labelNombre.UseWaitCursor = true;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(183, 65);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(27, 29);
            this.labelApellido.TabIndex = 7;
            this.labelApellido.Text = "a";
            this.labelApellido.UseWaitCursor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(183, 106);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(20, 29);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "t";
            this.labelTotal.UseWaitCursor = true;
            // 
            // MantenedorMetodosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.Controls.Add(this.btnComprobantePago);
            this.Controls.Add(this.panelTarjeta);
            this.Controls.Add(this.panelEfectivo);
            this.Controls.Add(this.btntarjeta);
            this.Controls.Add(this.btnEfectivo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorMetodosPago";
            this.Text = "FormasPago";
            this.panelEfectivo.ResumeLayout(false);
            this.panelEfectivo.PerformLayout();
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btntarjeta;
        private System.Windows.Forms.Panel panelEfectivo;
        private System.Windows.Forms.Panel panelTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComprobantePago;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
    }
}