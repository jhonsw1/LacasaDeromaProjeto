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
    public partial class CadastroIngredientes : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        public CadastroIngredientes()
        {
            InitializeComponent();
        }
        private void salvar()
        {
            Ingredientess procurar = new Ingredientess();
            procurar = bd.Ingredientess.Where(a => a.nome.Equals(txtNome.Text)).FirstOrDefault();

            if(procurar != null)
            {
                MessageBox.Show("Ingrediente já cadastrado!!!");
            }
            else
            {
                Ingredientess salvar = new Ingredientess()
                {
                    nome = txtNome.Text,
                    preco = Convert.ToDouble(txtPreco.Text),
                    quantidade = Convert.ToInt32(txtQtd.Text)
                };
                MessageBox.Show("Salvo com sucesso!!!");
                bd.Ingredientess.Add(salvar);
                bd.SaveChanges();
             
                this.ingredientessTableAdapter.Fill(this.lacasa_romaDataSet15.Ingredientess);
                carregaTabela();
                limparCampo();
            }
        }
        private void carregaTabela()
        {
            dataGridView1.DataSource = bd.Ingredientess.ToList();
        }
        private void limparCampo()
        {
            cmbNome.Text = "";
            txtNome.Clear();
            txtPreco.Clear();
            txtQtd.Clear();
        }
        private void excluir()
        {
            Ingredientess excluirIngrediente = new Ingredientess();
            excluirIngrediente = bd.Ingredientess.Where(a => a.nome.Equals(cmbNome.Text)).FirstOrDefault();
            if (MessageBox.Show("Tem certeza que deseja excluir o produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.Ingredientess.Remove(excluirIngrediente);
                bd.SaveChanges();
                MessageBox.Show("EXCLUIDO COM SUCESSO");
               
                this.ingredientessTableAdapter.Fill(this.lacasa_romaDataSet15.Ingredientess);
                limparCampo();
                carregaTabela();

            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void CadastroIngredientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet15.Ingredientess'. Você pode movê-la ou removê-la conforme necessário.
            this.ingredientessTableAdapter.Fill(this.lacasa_romaDataSet15.Ingredientess);
            limparCampo();
            carregaTabela();
        }
    }
}

