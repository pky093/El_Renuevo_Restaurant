namespace proyectoFinalMoanso
{
    partial class PrincipalAdmin
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
            this.BtnListarComrpobante = new System.Windows.Forms.Button();
            this.btnListarComprobante = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnListarComrpobante
            // 
            this.BtnListarComrpobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.BtnListarComrpobante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnListarComrpobante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.BtnListarComrpobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarComrpobante.Font = new System.Drawing.Font("Microsoft Uighur", 36F);
            this.BtnListarComrpobante.Location = new System.Drawing.Point(523, 73);
            this.BtnListarComrpobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListarComrpobante.Name = "BtnListarComrpobante";
            this.BtnListarComrpobante.Size = new System.Drawing.Size(381, 126);
            this.BtnListarComrpobante.TabIndex = 0;
            this.BtnListarComrpobante.Text = "Lista de Cliente";
            this.BtnListarComrpobante.UseVisualStyleBackColor = false;
            this.BtnListarComrpobante.Click += new System.EventHandler(this.BtnListarComrpobante_Click);
            // 
            // btnListarComprobante
            // 
            this.btnListarComprobante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnListarComprobante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.btnListarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarComprobante.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarComprobante.Location = new System.Drawing.Point(43, 73);
            this.btnListarComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarComprobante.Name = "btnListarComprobante";
            this.btnListarComprobante.Size = new System.Drawing.Size(381, 126);
            this.btnListarComprobante.TabIndex = 1;
            this.btnListarComprobante.Text = "Listas de Comprobantes";
            this.btnListarComprobante.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(137)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 36F);
            this.button3.Location = new System.Drawing.Point(237, 345);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(432, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Control de stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(933, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnListarComprobante);
            this.Controls.Add(this.BtnListarComrpobante);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalAdmin";
            this.Text = "PrincipalAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListarComrpobante;
        private System.Windows.Forms.Button btnListarComprobante;
        private System.Windows.Forms.Button button3;
    }
}