
namespace CrudClientes
{
    partial class FrmCrudCliente
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudCliente));
            this.grpDadosP = new System.Windows.Forms.GroupBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.labDataNascimento = new System.Windows.Forms.Label();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.labSobreNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.labUF = new System.Windows.Forms.Label();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.labNumero = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.labRua = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.btnAlterarDadosCliente = new System.Windows.Forms.Button();
            this.btnExcluirDadosCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesqisar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpDadosP.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosP
            // 
            this.grpDadosP.Controls.Add(this.dtpDataNasc);
            this.grpDadosP.Controls.Add(this.labDataNascimento);
            this.grpDadosP.Controls.Add(this.txtSobreNome);
            this.grpDadosP.Controls.Add(this.labSobreNome);
            this.grpDadosP.Controls.Add(this.txtNome);
            this.grpDadosP.Controls.Add(this.labNome);
            this.grpDadosP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDadosP.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpDadosP.Location = new System.Drawing.Point(14, 168);
            this.grpDadosP.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.grpDadosP.Name = "grpDadosP";
            this.grpDadosP.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.grpDadosP.Size = new System.Drawing.Size(431, 129);
            this.grpDadosP.TabIndex = 0;
            this.grpDadosP.TabStop = false;
            this.grpDadosP.Text = "Dados Pessoais";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(126, 84);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(248, 29);
            this.dtpDataNasc.TabIndex = 5;
            // 
            // labDataNascimento
            // 
            this.labDataNascimento.AutoSize = true;
            this.labDataNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDataNascimento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labDataNascimento.Location = new System.Drawing.Point(7, 86);
            this.labDataNascimento.Margin = new System.Windows.Forms.Padding(0);
            this.labDataNascimento.Name = "labDataNascimento";
            this.labDataNascimento.Size = new System.Drawing.Size(117, 19);
            this.labDataNascimento.TabIndex = 4;
            this.labDataNascimento.Text = "Data Nascimento:";
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSobreNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobreNome.Location = new System.Drawing.Point(126, 53);
            this.txtSobreNome.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(248, 23);
            this.txtSobreNome.TabIndex = 3;
            this.txtSobreNome.UseWaitCursor = true;
            // 
            // labSobreNome
            // 
            this.labSobreNome.AutoSize = true;
            this.labSobreNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSobreNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labSobreNome.Location = new System.Drawing.Point(7, 57);
            this.labSobreNome.Margin = new System.Windows.Forms.Padding(0);
            this.labSobreNome.Name = "labSobreNome";
            this.labSobreNome.Size = new System.Drawing.Size(88, 19);
            this.labSobreNome.TabIndex = 2;
            this.labSobreNome.Text = "Sobre Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(126, 25);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 23);
            this.txtNome.TabIndex = 1;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labNome.Location = new System.Drawing.Point(7, 29);
            this.labNome.Margin = new System.Windows.Forms.Padding(0);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(59, 19);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Nome *:";
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtUF);
            this.grpEndereco.Controls.Add(this.labUF);
            this.grpEndereco.Controls.Add(this.txtNumCasa);
            this.grpEndereco.Controls.Add(this.labNumero);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.labCidade);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.labBairro);
            this.grpEndereco.Controls.Add(this.txtRua);
            this.grpEndereco.Controls.Add(this.labRua);
            this.grpEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEndereco.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpEndereco.Location = new System.Drawing.Point(14, 307);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.grpEndereco.Size = new System.Drawing.Size(431, 125);
            this.grpEndereco.TabIndex = 1;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUF.Location = new System.Drawing.Point(341, 58);
            this.txtUF.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(66, 23);
            this.txtUF.TabIndex = 9;
            // 
            // labUF
            // 
            this.labUF.AutoSize = true;
            this.labUF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUF.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labUF.Location = new System.Drawing.Point(303, 59);
            this.labUF.Margin = new System.Windows.Forms.Padding(0);
            this.labUF.Name = "labUF";
            this.labUF.Size = new System.Drawing.Size(29, 19);
            this.labUF.TabIndex = 8;
            this.labUF.Text = "UF:";
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumCasa.Location = new System.Drawing.Point(341, 27);
            this.txtNumCasa.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(66, 23);
            this.txtNumCasa.TabIndex = 7;
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labNumero.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labNumero.Location = new System.Drawing.Point(302, 28);
            this.labNumero.Margin = new System.Windows.Forms.Padding(0);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(28, 19);
            this.labNumero.TabIndex = 6;
            this.labNumero.Text = "Nº:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(68, 88);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(202, 23);
            this.txtCidade.TabIndex = 5;
            // 
            // labCidade
            // 
            this.labCidade.AutoSize = true;
            this.labCidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCidade.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labCidade.Location = new System.Drawing.Point(4, 90);
            this.labCidade.Margin = new System.Windows.Forms.Padding(0);
            this.labCidade.Name = "labCidade";
            this.labCidade.Size = new System.Drawing.Size(54, 19);
            this.labCidade.TabIndex = 4;
            this.labCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(68, 58);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 23);
            this.txtBairro.TabIndex = 3;
            // 
            // labBairro
            // 
            this.labBairro.AutoSize = true;
            this.labBairro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labBairro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labBairro.Location = new System.Drawing.Point(4, 60);
            this.labBairro.Margin = new System.Windows.Forms.Padding(0);
            this.labBairro.Name = "labBairro";
            this.labBairro.Size = new System.Drawing.Size(48, 19);
            this.labBairro.TabIndex = 2;
            this.labBairro.Text = "Bairro:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(68, 27);
            this.txtRua.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(202, 23);
            this.txtRua.TabIndex = 1;
            // 
            // labRua
            // 
            this.labRua.AutoSize = true;
            this.labRua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labRua.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labRua.Location = new System.Drawing.Point(5, 29);
            this.labRua.Margin = new System.Windows.Forms.Padding(0);
            this.labRua.Name = "labRua";
            this.labRua.Size = new System.Drawing.Size(35, 19);
            this.labRua.TabIndex = 0;
            this.labRua.Text = "Rua:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCliente.Image = global::CrudClientes.Properties.Resources.add;
            this.btnAddCliente.Location = new System.Drawing.Point(19, 12);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(70, 85);
            this.btnAddCliente.TabIndex = 2;
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Image = global::CrudClientes.Properties.Resources.borracha;
            this.btnLimparTela.Location = new System.Drawing.Point(370, 13);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(70, 85);
            this.btnLimparTela.TabIndex = 3;
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnAlterarDadosCliente
            // 
            this.btnAlterarDadosCliente.Image = global::CrudClientes.Properties.Resources.alterar;
            this.btnAlterarDadosCliente.Location = new System.Drawing.Point(198, 13);
            this.btnAlterarDadosCliente.Name = "btnAlterarDadosCliente";
            this.btnAlterarDadosCliente.Size = new System.Drawing.Size(70, 85);
            this.btnAlterarDadosCliente.TabIndex = 4;
            this.btnAlterarDadosCliente.UseVisualStyleBackColor = true;
            this.btnAlterarDadosCliente.Click += new System.EventHandler(this.btnAlterarDadosCliente_Click);
            // 
            // btnExcluirDadosCliente
            // 
            this.btnExcluirDadosCliente.Image = global::CrudClientes.Properties.Resources.lixo;
            this.btnExcluirDadosCliente.Location = new System.Drawing.Point(283, 13);
            this.btnExcluirDadosCliente.Name = "btnExcluirDadosCliente";
            this.btnExcluirDadosCliente.Size = new System.Drawing.Size(70, 85);
            this.btnExcluirDadosCliente.TabIndex = 5;
            this.btnExcluirDadosCliente.UseVisualStyleBackColor = true;
            this.btnExcluirDadosCliente.Click += new System.EventHandler(this.btnExcluirDadosCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesqisar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesqisar
            // 
            this.btnPesqisar.Location = new System.Drawing.Point(341, 25);
            this.btnPesqisar.Name = "btnPesqisar";
            this.btnPesqisar.Size = new System.Drawing.Size(84, 27);
            this.btnPesqisar.TabIndex = 4;
            this.btnPesqisar.Text = "Pesquisar";
            this.btnPesqisar.UseVisualStyleBackColor = true;
            this.btnPesqisar.Click += new System.EventHandler(this.btnPesqisar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.Location = new System.Drawing.Point(82, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(109, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 85);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 446);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.btnExcluirDadosCliente);
            this.Controls.Add(this.btnAlterarDadosCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpDadosP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCrudCliente";
            this.Text = "Cadastro de Cliente";
            this.grpDadosP.ResumeLayout(false);
            this.grpDadosP.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpDadosP;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label labSobreNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labDataNascimento;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.Label labCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label labBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label labRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label labUF;
        private System.Windows.Forms.TextBox txtNumCasa;
        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnAlterarDadosCliente;
        private System.Windows.Forms.Button btnExcluirDadosCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesqisar;
    }
}

