namespace Heranca
{
    partial class frmConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConta));
            this.btnSacar = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.ltbExtrato = new System.Windows.Forms.ListBox();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.txtTransferir = new System.Windows.Forms.TextBox();
            this.lblTransferir = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnMostrarSaldo = new System.Windows.Forms.Button();
            this.rdbContaCorrente = new System.Windows.Forms.RadioButton();
            this.rdbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(92, 363);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(155, 49);
            this.btnSacar.TabIndex = 0;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.rdbContaPoupanca);
            this.gpbInformacoes.Controls.Add(this.rdbContaCorrente);
            this.gpbInformacoes.Controls.Add(this.ltbExtrato);
            this.gpbInformacoes.Controls.Add(this.lblExtrato);
            this.gpbInformacoes.Controls.Add(this.txtTransferir);
            this.gpbInformacoes.Controls.Add(this.lblTransferir);
            this.gpbInformacoes.Controls.Add(this.txtDepositar);
            this.gpbInformacoes.Controls.Add(this.lblDepositar);
            this.gpbInformacoes.Controls.Add(this.txtValor);
            this.gpbInformacoes.Controls.Add(this.lblValor);
            this.gpbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoes.Location = new System.Drawing.Point(92, 76);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(643, 263);
            this.gpbInformacoes.TabIndex = 1;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informaçõs da Conta";
            // 
            // ltbExtrato
            // 
            this.ltbExtrato.FormattingEnabled = true;
            this.ltbExtrato.ItemHeight = 20;
            this.ltbExtrato.Location = new System.Drawing.Point(451, 56);
            this.ltbExtrato.Name = "ltbExtrato";
            this.ltbExtrato.Size = new System.Drawing.Size(177, 164);
            this.ltbExtrato.TabIndex = 7;
            // 
            // lblExtrato
            // 
            this.lblExtrato.AutoSize = true;
            this.lblExtrato.Location = new System.Drawing.Point(447, 35);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(60, 20);
            this.lblExtrato.TabIndex = 6;
            this.lblExtrato.Text = "Extrato";
            // 
            // txtTransferir
            // 
            this.txtTransferir.Location = new System.Drawing.Point(17, 179);
            this.txtTransferir.MaxLength = 10;
            this.txtTransferir.Name = "txtTransferir";
            this.txtTransferir.Size = new System.Drawing.Size(147, 26);
            this.txtTransferir.TabIndex = 5;
            // 
            // lblTransferir
            // 
            this.lblTransferir.AutoSize = true;
            this.lblTransferir.Location = new System.Drawing.Point(23, 156);
            this.lblTransferir.Name = "lblTransferir";
            this.lblTransferir.Size = new System.Drawing.Size(76, 20);
            this.lblTransferir.TabIndex = 4;
            this.lblTransferir.Text = "Transferir";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(17, 114);
            this.txtDepositar.MaxLength = 10;
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(147, 26);
            this.txtDepositar.TabIndex = 3;
            // 
            // lblDepositar
            // 
            this.lblDepositar.AutoSize = true;
            this.lblDepositar.Location = new System.Drawing.Point(23, 91);
            this.lblDepositar.Name = "lblDepositar";
            this.lblDepositar.Size = new System.Drawing.Size(78, 20);
            this.lblDepositar.TabIndex = 2;
            this.lblDepositar.Text = "Depositar";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 56);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(147, 26);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(23, 33);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(258, 363);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(155, 49);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(419, 363);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(155, 49);
            this.btnTransferir.TabIndex = 9;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnMostrarSaldo
            // 
            this.btnMostrarSaldo.Location = new System.Drawing.Point(580, 363);
            this.btnMostrarSaldo.Name = "btnMostrarSaldo";
            this.btnMostrarSaldo.Size = new System.Drawing.Size(155, 49);
            this.btnMostrarSaldo.TabIndex = 10;
            this.btnMostrarSaldo.Text = "Mostrar Saldo";
            this.btnMostrarSaldo.UseVisualStyleBackColor = true;
            // 
            // rdbContaCorrente
            // 
            this.rdbContaCorrente.AutoSize = true;
            this.rdbContaCorrente.Location = new System.Drawing.Point(244, 56);
            this.rdbContaCorrente.Name = "rdbContaCorrente";
            this.rdbContaCorrente.Size = new System.Drawing.Size(136, 24);
            this.rdbContaCorrente.TabIndex = 8;
            this.rdbContaCorrente.TabStop = true;
            this.rdbContaCorrente.Text = "Conta Corrente";
            this.rdbContaCorrente.UseVisualStyleBackColor = true;
            // 
            // rdbContaPoupanca
            // 
            this.rdbContaPoupanca.AutoSize = true;
            this.rdbContaPoupanca.Location = new System.Drawing.Point(244, 114);
            this.rdbContaPoupanca.Name = "rdbContaPoupanca";
            this.rdbContaPoupanca.Size = new System.Drawing.Size(146, 24);
            this.rdbContaPoupanca.TabIndex = 9;
            this.rdbContaPoupanca.TabStop = true;
            this.rdbContaPoupanca.Text = "Conta Poupança";
            this.rdbContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarSaldo);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSacar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.TextBox txtTransferir;
        private System.Windows.Forms.Label lblTransferir;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Label lblDepositar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.ListBox ltbExtrato;
        private System.Windows.Forms.Label lblExtrato;
        private System.Windows.Forms.Button btnMostrarSaldo;
        private System.Windows.Forms.RadioButton rdbContaPoupanca;
        private System.Windows.Forms.RadioButton rdbContaCorrente;
    }
}