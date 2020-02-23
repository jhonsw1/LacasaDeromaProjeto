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
    public partial class TelaLog : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        cadastroUsuario usuario = new cadastroUsuario();
        public TelaLog()
        {
            InitializeComponent();
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                //Verificando se o usuario que o usuario digito existe
                usuario = bd.cadastroUsuario.Where(a => a.nome.Equals(txtNome.Text) && a.senha.Equals(txtSenha.Text)).FirstOrDefault();

                if (usuario != null)
                {
                    new ReservaMesas().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                    txtNome.Clear();
                    txtSenha.Clear();
                
                }
            
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RecuperarConta().Show();
            this.Hide();
        }
    }
}

