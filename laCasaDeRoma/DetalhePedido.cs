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
    public partial class DetalhePedido : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        public DetalhePedido()
        {
            InitializeComponent();
            carregaTabela();
        }
     private void carregaTabela()
        {
            dataGridView1.DataSource = bd.DetalhePedidoMesa.ToList();
        }
    }
}
