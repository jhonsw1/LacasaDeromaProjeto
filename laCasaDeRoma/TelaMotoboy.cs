using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laCasaDeRoma
{
    public partial class TelaMotoboy : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
       
        public TelaMotoboy()
        {
            InitializeComponent();
            carregaTabela();
        }
       private void salvar()
        {
            CadastroEntregadores cadastrar = new CadastroEntregadores()
            {
                nome = txtNome.Text,
                placa = txtPlaca.Text,
                endereco = txtEndereco.Text,
                cpf = txtCpf.Text
            };
            bd.CadastroEntregadores.Add(cadastrar);
            bd.SaveChanges();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtPlaca.Clear();
            carregaTabela();
        }
        private void carregaTabela()
        {
            tblEntregador.DataSource = bd.CadastroEntregadores.ToList();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            salvar();
        }
        private void excluir()
        {
            CadastroEntregadores excluindo = new CadastroEntregadores();
            excluindo = bd.CadastroEntregadores.Where(a => a.nome.Equals(cmbVerificar.Text)).FirstOrDefault();
            bd.CadastroEntregadores.Remove(excluindo);
            bd.SaveChanges();
            MessageBox.Show("Cadastro apagado");
            carregaTabela();
        }
        

        private void TelaMotoboy_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet1.CadastroEntregadores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroEntregadoresTableAdapter.Fill(this.lacasa_romaDataSet1.CadastroEntregadores);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }
    }
}
