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
    public partial class CadastrarUsuario : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
       
        public CadastrarUsuario()
        {
            InitializeComponent();
           
        }
        private void salvar()
        {
            cadastroUsuario cadastro = new cadastroUsuario();
          
            cadastro = bd.cadastroUsuario.Where(a => a.nome.Equals(txtNome.Text) || a.cpf.Equals(txtCpf.Text)).FirstOrDefault();

            if (cadastro != null)
            {
                MessageBox.Show("Tipo de conta já cadastrado \n Digite outra");
            }
            else
            {
                cadastroUsuario cadastrou = new cadastroUsuario()
                {
                    nome = txtNome.Text,
                    senha = txtSenha.Text,
                    cpf = txtCpf.Text,



                };
                MessageBox.Show("Cadastro efetuado com sucesso!!");
                bd.cadastroUsuario.Add(cadastrou);
                bd.SaveChanges();
                txtNome.Clear();
                txtSenha.Clear();
                txtCpf.Clear();

                if (MessageBox.Show("Deseja Deseja retornar para tela de Log ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new TelaLog().Show();
                    this.Hide();
                }
            };
          
            
        }
            private void btnCadastrar_Click(object sender, EventArgs e)
        {
            salvar();
            
        }

        private void TxtVoltar_Click(object sender, EventArgs e)
        {
            new ReservaMesas().Show();
            this.Hide();
        }
    }
}
