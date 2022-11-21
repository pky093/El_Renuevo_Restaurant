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
            this.BtnListarComrpobante.Location = new System.Drawing.Point(60, 71);
            this.BtnListarComrpobante.Name = "BtnListarComrpobante";
            this.BtnListarComrpobante.Size = new System.Drawing.Size(351, 126);
            this.BtnListarComrpobante.TabIndex = 0;
            this.BtnListarComrpobante.Text = "Listar Cliente";
            this.BtnListarComrpobante.UseVisualStyleBackColor = true;
            this.BtnListarComrpobante.Click += new System.EventHandler(this.BtnListarComrpobante_Click);
            // 
            // btnListarComprobante
            // 
            this.btnListarComprobante.Location = new System.Drawing.Point(514, 71);
            this.btnListarComprobante.Name = "btnListarComprobante";
            this.btnListarComprobante.Size = new System.Drawing.Size(346, 126);
            this.btnListarComprobante.TabIndex = 1;
            this.btnListarComprobante.Text = "Listar Comprobante";
            this.btnListarComprobante.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(432, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "agregar insumos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnListarComprobante);
            this.Controls.Add(this.BtnListarComrpobante);
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