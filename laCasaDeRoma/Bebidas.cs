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
    public partial class Bebidas : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        public Bebidas()
        {
            InitializeComponent();
        }
     private void LimparCombobox()
        {
            cmbBebida.Text = "";
            cmbValor.Text = "";
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet33.CadastroBebida'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroBebidaTableAdapter.Fill(this.lacasa_romaDataSet33.CadastroBebida);
            LimparCombobox();
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
        /*private void salvarBebida()
        {
            DetalhePedidoMesa guardarBebida = new DetalhePedidoMesa()
            {
                Bebida = cmbBebida.Text
            };
            bd.DetalhePedidoMesa.Add(guardarBebida);
            bd.SaveChanges();
        
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarValor();
           // salvarBebida();
            LimparCombobox();
        }
    }

}
