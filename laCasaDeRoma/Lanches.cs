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
    public partial class Lanches : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        public Lanches()
        {
            InitializeComponent();
        }
      

        private void Lanches_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet32.CadastroLanche'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroLancheTableAdapter.Fill(this.lacasa_romaDataSet32.CadastroLanche);
            limparCombobox();
        }
        private void limparCombobox()
        {
            cmbLanche.Text = "";
            cmbValor.Text = "";
        }
        private void GuardarValor()
        {
            SomarPedidos guardar = new SomarPedidos()
            {
                Somar = Convert.ToDouble(cmbValor.Text),
            };
            bd.SomarPedidos.Add(guardar);
            bd.SaveChanges();
            
          

        }
        /*private void salvarLanche()
        {
            DetalhePedidoMesa guardarLanche = new DetalhePedidoMesa()
            {
                Lanche = cmbLanche.Text
            };
            bd.DetalhePedidoMesa.Add(guardarLanche);
            bd.SaveChanges();
         
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarValor();
            //salvarLanche();
            limparCombobox();
        }
    }
}
