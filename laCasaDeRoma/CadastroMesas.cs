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
    public partial class CadastroMesas : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
       
        public CadastroMesas()
        {
            InitializeComponent();
            btnSalvar.Click += Salvar;
            carregaTabelaMesas();
         
        }
     

        private void Salvar(object sender, EventArgs e)
        {
            mesas cadastrarr = new mesas()
            {
                capacidade = Convert.ToInt32(txtCapacidade.Text),
                disponivel = true,
                

             

        };
           
            
            MessageBox.Show("Cadastro Efetuado com sucesso!!");
            bd.mesas.Add(cadastrarr);
            bd.SaveChanges();
            txtCapacidade.Clear();

            carregaTabelaMesas();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            new ReservaMesas().Show();
            this.Hide();
        }
       private void carregaTabelaMesas()
        {
            dataGridView1.DataSource = bd.mesas.ToList();
        }

       
    }

        
    
}
