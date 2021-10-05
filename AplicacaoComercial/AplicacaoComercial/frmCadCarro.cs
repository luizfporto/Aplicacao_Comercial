using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoComercial
{
    public partial class frmCadCarro : Form
    {
        public frmCadCarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void frmCadCarro_Load(object sender, EventArgs e)
        {
            cboCor.DataSource = Enum.GetNames(typeof(Veiculo.Cores));
            dgvCarros.DataSource = Carro.Consultar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                Carro c = new Carro(
                txtMarca.Text,
               txtModelo.Text,
               int.Parse(txtAno.Text),
               (Veiculo.Cores)cboCor.SelectedIndex,
                int.Parse(txtPortas.Text)
                );
                c.Incluir();
                MessageBox.Show("Dados cadastrados com sucesso.",
                "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            else
            {
                Carro c = new Carro(
                int.Parse(txtId.Text),
               txtMarca.Text,
               txtModelo.Text,
               int.Parse(txtAno.Text),
               (Veiculo.Cores)cboCor.SelectedIndex,
                int.Parse(txtPortas.Text)
                ); c.Alterar();
                MessageBox.Show("Dados alterados com sucesso.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            PreencherGrid(Carro.Consultar());
            LimparCampos();
        }

        private void LimparCampos()
            {

                txtId.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtAno.Text = "";
                txtPortas.Text = "";
                cboCor.SelectedIndex = 0;
            }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            Carro.Preencher();
            PreencherGrid(Carro.Consultar());

        }

        private void btnFiltrarMarca_Click(object sender, EventArgs e)
        {
            PreencherGrid(Carro.Consultar(txtMarca.Text));
        }

        private void dgvCarros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)dgvCarros["Id", e.RowIndex].Value;
            Carro c = new Carro(id);
            txtId.Text = c.Id.ToString();
            txtMarca.Text = c.Marca;
            txtModelo.Text = c.Modelo;
            txtAno.Text = c.Ano.ToString();
            cboCor.SelectedIndex = (int)c.Cor;
            txtPortas.Text = c.Portas.ToString();
        }
        private void PreencherGrid(List<Carro> lista)
        {
            dgvCarros.DataSource = new BindingList<Carro>(lista);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length != 0)
            {
                Carro.Excluir(int.Parse(txtId.Text));
                MessageBox.Show("Registro excluído com sucesso.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                PreencherGrid(Carro.Consultar());
                LimparCampos();
            }
            else
                MessageBox.Show("Selecione um registro para excluir.",
                "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);

        }
    }
}
