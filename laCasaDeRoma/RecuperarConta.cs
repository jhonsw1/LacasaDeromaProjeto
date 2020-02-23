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
    public partial class RecuperarConta : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        
      

        public RecuperarConta()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaLog().Show();
            this.Hide();
        }
        private void MostrarLog()
        {
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroUsuario verificar = new cadastroUsuario();
            verificar = bd.cadastroUsuario.Where(a => a.cpf.Equals(txtVerificar.Text)).FirstOrDefault();
            if(verificar != null)
            {
                MessageBox.Show("Conta encontrada");
                

                mostrar.Text = verificar.nome;
                mostrar1.Text = verificar.senha;

                txtVerificar.Clear();
                
                
            }
            else
            {
                MessageBox.Show("ATENÇÃO CPF INVALIDO!!! \n digite um CPF cadastrado");
                txtVerificar.Clear();
            }
        }

      
    }
}
