﻿namespace GeradorCNAB
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbHeaderArquivo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtDVAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtDVConta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoInscricaoEmpresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNimeroInscricaoEmpresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoConvenioBanco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataGeracaoArquivo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpHorarioGeracaoArquivo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNSA = new System.Windows.Forms.TextBox();
            this.txtVLayout = new System.Windows.Forms.TextBox();
            this.gbHeaderArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeaderArquivo
            // 
            this.gbHeaderArquivo.Controls.Add(this.txtVLayout);
            this.gbHeaderArquivo.Controls.Add(this.txtNSA);
            this.gbHeaderArquivo.Controls.Add(this.label13);
            this.gbHeaderArquivo.Controls.Add(this.label12);
            this.gbHeaderArquivo.Controls.Add(this.dtpHorarioGeracaoArquivo);
            this.gbHeaderArquivo.Controls.Add(this.label11);
            this.gbHeaderArquivo.Controls.Add(this.dtpDataGeracaoArquivo);
            this.gbHeaderArquivo.Controls.Add(this.label10);
            this.gbHeaderArquivo.Controls.Add(this.txtCodigoConvenioBanco);
            this.gbHeaderArquivo.Controls.Add(this.label9);
            this.gbHeaderArquivo.Controls.Add(this.txtNimeroInscricaoEmpresa);
            this.gbHeaderArquivo.Controls.Add(this.label8);
            this.gbHeaderArquivo.Controls.Add(this.cmbTipoInscricaoEmpresa);
            this.gbHeaderArquivo.Controls.Add(this.label7);
            this.gbHeaderArquivo.Controls.Add(this.txtNomeEmpresa);
            this.gbHeaderArquivo.Controls.Add(this.label6);
            this.gbHeaderArquivo.Controls.Add(this.txtDVConta);
            this.gbHeaderArquivo.Controls.Add(this.txtConta);
            this.gbHeaderArquivo.Controls.Add(this.txtDVAgencia);
            this.gbHeaderArquivo.Controls.Add(this.txtAgencia);
            this.gbHeaderArquivo.Controls.Add(this.label5);
            this.gbHeaderArquivo.Controls.Add(this.label4);
            this.gbHeaderArquivo.Controls.Add(this.label3);
            this.gbHeaderArquivo.Controls.Add(this.label2);
            this.gbHeaderArquivo.Controls.Add(this.cmbBancos);
            this.gbHeaderArquivo.Controls.Add(this.label1);
            this.gbHeaderArquivo.Location = new System.Drawing.Point(12, 12);
            this.gbHeaderArquivo.Name = "gbHeaderArquivo";
            this.gbHeaderArquivo.Size = new System.Drawing.Size(572, 229);
            this.gbHeaderArquivo.TabIndex = 0;
            this.gbHeaderArquivo.TabStop = false;
            this.gbHeaderArquivo.Text = "Header do Arquivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Banco:";
            // 
            // cmbBancos
            // 
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(112, 27);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(454, 21);
            this.cmbBancos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "D.V:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "D.V:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(61, 54);
            this.txtAgencia.MaxLength = 5;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 6;
            // 
            // txtDVAgencia
            // 
            this.txtDVAgencia.Location = new System.Drawing.Point(208, 54);
            this.txtDVAgencia.MaxLength = 1;
            this.txtDVAgencia.Name = "txtDVAgencia";
            this.txtDVAgencia.Size = new System.Drawing.Size(21, 20);
            this.txtDVAgencia.TabIndex = 7;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(314, 54);
            this.txtConta.MaxLength = 12;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 8;
            // 
            // txtDVConta
            // 
            this.txtDVConta.Location = new System.Drawing.Point(461, 54);
            this.txtDVConta.MaxLength = 1;
            this.txtDVConta.Name = "txtDVConta";
            this.txtDVConta.Size = new System.Drawing.Size(21, 20);
            this.txtDVConta.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome da Empresa:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(112, 80);
            this.txtNomeEmpresa.MaxLength = 30;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(454, 20);
            this.txtNomeEmpresa.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Inscrição da Empresa:";
            // 
            // cmbTipoInscricaoEmpresa
            // 
            this.cmbTipoInscricaoEmpresa.FormattingEnabled = true;
            this.cmbTipoInscricaoEmpresa.Location = new System.Drawing.Point(163, 136);
            this.cmbTipoInscricaoEmpresa.Name = "cmbTipoInscricaoEmpresa";
            this.cmbTipoInscricaoEmpresa.Size = new System.Drawing.Size(49, 21);
            this.cmbTipoInscricaoEmpresa.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número de Inscrição da Empresa:";
            // 
            // txtNimeroInscricaoEmpresa
            // 
            this.txtNimeroInscricaoEmpresa.Location = new System.Drawing.Point(476, 136);
            this.txtNimeroInscricaoEmpresa.MaxLength = 14;
            this.txtNimeroInscricaoEmpresa.Name = "txtNimeroInscricaoEmpresa";
            this.txtNimeroInscricaoEmpresa.Size = new System.Drawing.Size(90, 20);
            this.txtNimeroInscricaoEmpresa.TabIndex = 15;
            this.txtNimeroInscricaoEmpresa.Text = "0000000000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código do Convênio no Banco:";
            // 
            // txtCodigoConvenioBanco
            // 
            this.txtCodigoConvenioBanco.Location = new System.Drawing.Point(163, 107);
            this.txtCodigoConvenioBanco.MaxLength = 20;
            this.txtCodigoConvenioBanco.Name = "txtCodigoConvenioBanco";
            this.txtCodigoConvenioBanco.Size = new System.Drawing.Size(403, 20);
            this.txtCodigoConvenioBanco.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Data de Geração do Arquivo:";
            // 
            // dtpDataGeracaoArquivo
            // 
            this.dtpDataGeracaoArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataGeracaoArquivo.Location = new System.Drawing.Point(163, 163);
            this.dtpDataGeracaoArquivo.Name = "dtpDataGeracaoArquivo";
            this.dtpDataGeracaoArquivo.Size = new System.Drawing.Size(95, 20);
            this.dtpDataGeracaoArquivo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Horario de Geração do Arquivo:";
            // 
            // dtpHorarioGeracaoArquivo
            // 
            this.dtpHorarioGeracaoArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioGeracaoArquivo.Location = new System.Drawing.Point(488, 163);
            this.dtpHorarioGeracaoArquivo.Name = "dtpHorarioGeracaoArquivo";
            this.dtpHorarioGeracaoArquivo.Size = new System.Drawing.Size(78, 20);
            this.dtpHorarioGeracaoArquivo.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Seqüencial (NSA):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Layout do Arquivo:";
            // 
            // txtNSA
            // 
            this.txtNSA.Location = new System.Drawing.Point(102, 193);
            this.txtNSA.MaxLength = 6;
            this.txtNSA.Name = "txtNSA";
            this.txtNSA.Size = new System.Drawing.Size(53, 20);
            this.txtNSA.TabIndex = 25;
            this.txtNSA.Text = "000001";
            // 
            // txtVLayout
            // 
            this.txtVLayout.Location = new System.Drawing.Point(306, 193);
            this.txtVLayout.MaxLength = 3;
            this.txtVLayout.Name = "txtVLayout";
            this.txtVLayout.Size = new System.Drawing.Size(29, 20);
            this.txtVLayout.TabIndex = 26;
            this.txtVLayout.Text = "103";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 260);
            this.Controls.Add(this.gbHeaderArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de CNAB 240";
            this.gbHeaderArquivo.ResumeLayout(false);
            this.gbHeaderArquivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeaderArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.TextBox txtDVConta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtDVAgencia;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVLayout;
        private System.Windows.Forms.TextBox txtNSA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpHorarioGeracaoArquivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDataGeracaoArquivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoConvenioBanco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNimeroInscricaoEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoInscricaoEmpresa;
        private System.Windows.Forms.Label label7;
    }
}
