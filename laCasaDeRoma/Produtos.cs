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
    public partial class Produtos : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        public Produtos()
        {
            InitializeComponent();
       
        }
        private void carregaTabela()
        {
            dataGridView1.DataSource = bd.CadastroLanche.ToList();
           
        }
        private void carregaTabela2()
        {
            dataGridView2.DataSource = bd.CadastroBebida.ToList();

        }
        private void salvarProd()
        {
            CadastroLanche cadastrar = new CadastroLanche();
           cadastrar = bd.CadastroLanche.Where(a => a.nome_Lanche.Equals(txtnomeProd.Text)).FirstOrDefault();

            if (cadastrar != null)
            {
                MessageBox.Show("Esse produto já efetue cadastro!!");
            }
            else
            {
                CadastroLanche cadastro = new CadastroLanche()
                {
                    nome_Lanche = txtnomeProd.Text

                };
                MessageBox.Show("Cadastro efetuado com sucesso!!!");
                bd.CadastroLanche.Add(cadastro);
                bd.SaveChanges();
                limpaComboBox();
                carregaTabela();



            }
        }
       

   
        private void limpaComboBox()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            txtnomeProd.Clear();
            txtvalorProd.Clear();
            txtvalorBebida.Clear();
            txtnomeBebida.Clear();


        }
     

        private void btnSalvarLanche_Click(object sender, EventArgs e)
        {
            salvarProd();
            
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            this.ingredientessTableAdapter11.Fill(this.lacasa_romaDataSet27.Ingredientess);
            this.ingredientessTableAdapter10.Fill(this.lacasa_romaDataSet26.Ingredientess);
            this.ingredientessTableAdapter9.Fill(this.lacasa_romaDataSet25.Ingredientess);
            this.ingredientessTableAdapter8.Fill(this.lacasa_romaDataSet24.Ingredientess);
            this.ingredientessTableAdapter7.Fill(this.lacasa_romaDataSet23.Ingredientess);
            this.ingredientessTableAdapter6.Fill(this.lacasa_romaDataSet22.Ingredientess);
            this.ingredientessTableAdapter5.Fill(this.lacasa_romaDataSet21.Ingredientess);
            this.ingredientessTableAdapter4.Fill(this.lacasa_romaDataSet20.Ingredientess);
            this.ingredientessTableAdapter3.Fill(this.lacasa_romaDataSet19.Ingredientess);
            this.ingredientessTableAdapter2.Fill(this.lacasa_romaDataSet18.Ingredientess);
            this.ingredientessTableAdapter1.Fill(this.lacasa_romaDataSet17.Ingredientess);
            this.ingredientessTableAdapter.Fill(this.lacasa_romaDataSet16.Ingredientess);
            limpaComboBox();
            carregaTabela();
            carregaTabela2();
        }
        private void salvarBebida()
        {
            CadastroBebida bebidas = new CadastroBebida();
            bebidas = bd.CadastroBebida.Where(a => a.bebida.Equals(txtnomeBebida.Text)).FirstOrDefault();
            if(bebidas != null)
            {
                MessageBox.Show("Bebida já cadastrado !!!");
            }
            else
            {
                CadastroBebida salvar = new CadastroBebida()
                {
                    bebida = txtnomeBebida.Text,
                    valor_Bebida = Convert.ToDouble(txtvalorBebida.Text)
                };
                bd.CadastroBebida.Add(salvar);
                bd.SaveChanges();
                limpaComboBox();
                MessageBox.Show("Salvo com sucesso!!");
                carregaTabela2();
            }

        }

        private void btnSalvarBebida_Click(object sender, EventArgs e)
        {
            salvarBebida();
        }
    }
}
