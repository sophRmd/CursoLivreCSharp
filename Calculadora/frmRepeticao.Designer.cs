namespace Calculadora
{
    partial class frmRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepeticao));
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.ltbListarCategorias = new System.Windows.Forms.ListBox();
            this.lblLitarCategorias = new System.Windows.Forms.Label();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(72, 61);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(167, 21);
            this.cbbCategorias.TabIndex = 0;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(72, 35);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(86, 20);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "Categorias";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(72, 229);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(145, 48);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // ltbListarCategorias
            // 
            this.ltbListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListarCategorias.FormattingEnabled = true;
            this.ltbListarCategorias.Location = new System.Drawing.Point(347, 61);
            this.ltbListarCategorias.Name = "ltbListarCategorias";
            this.ltbListarCategorias.Size = new System.Drawing.Size(241, 147);
            this.ltbListarCategorias.TabIndex = 3;
            // 
            // lblLitarCategorias
            // 
            this.lblLitarCategorias.AutoSize = true;
            this.lblLitarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitarCategorias.Location = new System.Drawing.Point(344, 38);
            this.lblLitarCategorias.Name = "lblLitarCategorias";
            this.lblLitarCategorias.Size = new System.Drawing.Size(129, 20);
            this.lblLitarCategorias.TabIndex = 4;
            this.lblLitarCategorias.Text = "Listar Categorias";
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(347, 229);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(145, 48);
            this.btnListarCategorias.TabIndex = 5;
            this.btnListarCategorias.Text = "Listar Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.lblLitarCategorias);
            this.Controls.Add(this.ltbListarCategorias);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbbCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repetiçâo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.ListBox ltbListarCategorias;
        private System.Windows.Forms.Label lblLitarCategorias;
        private System.Windows.Forms.Button btnListarCategorias;
    }
}