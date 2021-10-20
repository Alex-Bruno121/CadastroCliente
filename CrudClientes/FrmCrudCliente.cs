using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudClientes
{
    public partial class FrmCrudCliente : Form
    {
        public FrmCrudCliente()
        {
            InitializeComponent();
            DesabilitaCampos();
        }

        private void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtSobreNome.Enabled = false;
            dtpDataNasc.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumCasa.Enabled = false;
            txtUF.Enabled = false;
        }

        private void hablitaCampos()
        {
            txtBuscar.Enabled = true;
            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            dtpDataNasc.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumCasa.Enabled = true;
            txtUF.Enabled = true;
        }

        SqlConnection sqlCon = null;
        private string strCon = "Server=DESKTOP-9VF2NFF\\SQLEXPRESS;Database=develop;Trusted_Connection=True";
        private string strSql = string.Empty;

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            limpaTela();
            hablitaCampos();
            txtBuscar.Enabled = false;
            btnPesqisar.Enabled = false;
        }

        private void adicionaNovoCliente()
        {
            strSql = "INSERT INTO dbo.CLIENTE (NOME,SOBRE_NOME,DATA_NASCIMENTO,RUA,BAIRRO,CIDADE,NR_CASA,UF) VALUES (@nome, @sobre_nome, @data_nascimento, @rua, @bairro, @cidade, @nr_casa, @uf)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text.ToString();
            comando.Parameters.Add("@sobre_nome", SqlDbType.VarChar).Value = txtSobreNome.Text.ToString();
            comando.Parameters.Add("@data_nascimento", SqlDbType.DateTime).Value = dtpDataNasc.Value;
            comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtRua.Text.ToString();
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text.ToString();
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text.ToString();
            comando.Parameters.Add("@nr_casa", SqlDbType.Int).Value = txtNumCasa.Text.ToString();
            comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = txtUF.Text.ToString();

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");

                limpaTela();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void buscaCliente()
        {
            strSql = "select * from cliente where nome = @nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtBuscar.Text;

            try
            {
                sqlCon.Open();

                SqlDataReader sqlR = comando.ExecuteReader();

                if (sqlR.HasRows)
                {
                    while (sqlR.Read())
                    {
                        IDataRecord record = (IDataRecord)sqlR;

                        txtNome.Text = record[1].ToString();
                        txtSobreNome.Text = record[2].ToString();
                        dtpDataNasc.Text = record[3].ToString();
                        txtRua.Text = record[4].ToString();
                        txtBairro.Text = record[5].ToString();
                        txtCidade.Text = record[6].ToString();
                        txtNumCasa.Text = record[7].ToString();
                        txtUF.Text = record[8].ToString();

                    }

                    sqlR.Close();
                    hablitaCampos();
                }
                else
                {
                    limpaTela();
                    MessageBox.Show("NÃO FOI ENCONTRADO NENHUM CLIENTE COM ESTE NOME");
                    DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void limpaTela()
        {
            txtBuscar.Clear();
            txtNome.Clear();
            txtSobreNome.Clear();
            dtpDataNasc.Text = "";
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumCasa.Clear();
            txtUF.Clear();
        }

        private void btnAlterarDadosCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("PESQUISE UM CLIENTE ANTES DE TENTAR ALTERAR!");
                return;
            }
            else
            {
                strSql = "update dbo.CLIENTE set NOME = @nome,SOBRE_NOME = @sobre_nome," +
                    "DATA_NASCIMENTO = @data_nascimento,RUA = @rua,BAIRRO = @bairro," +
                    "CIDADE = @cidade ,NR_CASA = @nr_casa,UF = @uf where NOME = @nome ";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text.ToString();
                comando.Parameters.Add("@sobre_nome", SqlDbType.VarChar).Value = txtSobreNome.Text.ToString();
                comando.Parameters.Add("@data_nascimento", SqlDbType.DateTime).Value = dtpDataNasc.Value;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtRua.Text.ToString();
                comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text.ToString();
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text.ToString();
                comando.Parameters.Add("@nr_casa", SqlDbType.Int).Value = txtNumCasa.Text.ToString();
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = txtUF.Text.ToString();

                try
                {
                    sqlCon.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("CADASTRO ALTERADO COM SUCESSO");

                    limpaTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    DesabilitaCampos();
                }
            }
        }
        private void btnExcluirDadosCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("PESQUISE UM CLIENTE ANTES DE TENTAR EXCLUIR!");
                return;
            }
            else
            {
                strSql = "delete from dbo.CLIENTE where NOME = @nome and SOBRE_NOME = @sobre_nome";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text.ToString();
                comando.Parameters.Add("@sobre_nome", SqlDbType.VarChar).Value = txtSobreNome.Text.ToString();

                try
                {
                    sqlCon.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("CADASTRO EXCLUIDO COM SUCESSO");

                    limpaTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    DesabilitaCampos();
                    txtBuscar.Enabled = true;
                    btnPesqisar.Enabled = true;
                }
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
            limpaTela();
            txtBuscar.Enabled = true;
            btnPesqisar.Enabled = true;
        }

        private void SalvaCadastro()
        {

            if (txtNome.Text != string.Empty)
            {
                if (txtNumCasa.Text != string.Empty)
                {
                    adicionaNovoCliente();
                    DesabilitaCampos();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("PESQUISE UM CLIENTE ANTES DE TENTAR SALVAR");
            }

        }

        private void btnPesqisar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("NÃO É POSSÍVEL REALIZAR UMA BUSCA SEM INFORMAR UMA PALAVRA");
                return;
            }

            buscaCliente();
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            limpaTela();
            DesabilitaCampos();
        }
    }
}