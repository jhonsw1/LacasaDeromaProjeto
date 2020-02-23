using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace laCasaDeRoma
{
    public partial class ReservaMesas : Form
    {
        lacasa_romaEntities1 bd = new lacasa_romaEntities1();
        
           
        public ReservaMesas()
        {
           
            InitializeComponent();
           
        }
        double valores;
        private void montarMesas()
        {
            flowLayoutPanel1.Controls.Clear();
            bd.mesas.ToList().ForEach(m => {
                Panel p = new Panel();
                p.Width = 70;
                p.Height = 50;
                p.BackgroundImage = Properties.Resources.dinner_icon;
                p.BackgroundImageLayout = ImageLayout.Center;

                p.Name = m.id.ToString();
                p.Click += selecionaMesa;

                Label detalheMesa = new Label();
                
                detalheMesa.Text = $"mesa{m.id} Qtd: {m.capacidade}\n - {((m.disponivel) ? "Disponivel" : "Ocupado")}";
                
                flowLayoutPanel1.Controls.Add(detalheMesa);        
                flowLayoutPanel1.Controls.Add(p);
                if(m.disponivel != false)
                {
                    p.Click += abrirMesaOcupada;

                }
                

            });
            
            

        }
        private void abrirMesaOcupada(object sender, EventArgs e)
        {
            new DetalhePedido().Show();
        }
        private void selecionaMesa(object sender, EventArgs e)
        {
            Panel mesa = (Panel)sender;
            mesas mesaSelecionada = bd.mesas.Find(Convert.ToInt32(mesa.Name));
            mesaSelecionada.disponivel = !mesaSelecionada.disponivel;
            bd.SaveChanges();
            montarMesas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DetalhePedido().Show();
            this.Hide();
        }

        private void ReservaMesas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet31.mesas'. Você pode movê-la ou removê-la conforme necessário.
            this.mesasTableAdapter.Fill(this.lacasa_romaDataSet31.mesas);
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet29.CadastroMesass'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroMesassTableAdapter1.Fill(this.lacasa_romaDataSet29.CadastroMesass);
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet28.CadastroBebida'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroBebidaTableAdapter.Fill(this.lacasa_romaDataSet28.CadastroBebida);
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet9.CadastroLanche'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroLancheTableAdapter.Fill(this.lacasa_romaDataSet9.CadastroLanche);
            // TODO: esta linha de código carrega dados na tabela 'lacasa_romaDataSet.CadastroMesass'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroMesassTableAdapter.Fill(this.lacasa_romaDataSet.CadastroMesass);
            limparCampos();
            montarMesas();
           
           
        }
        private void MoveSpeedPanel1(Control c)
        {
            panel1.Height = c.Height;
            panel1.Top = c.Top;
        }
        private void DashboardDinamica(Form c, Panel a)
        {
            a.Controls.Clear();
            c.TopLevel = false;
            a.Controls.Add(c);
            c.WindowState = FormWindowState.Maximized;
            c.Dock = DockStyle.Fill;
            c.Show();
        }
       
    

        private void Button2_Click(object sender, EventArgs e)
        {
            new TelaMotoboy().Show();
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new CadastroMesas().Show();
            this.Hide();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new CadastroIngredientes().Show();
            
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            new CadastrarUsuario().Show();
            this.Hide();

        }
        private void voltar()
        {


       
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void Button_Click_(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Produtos().Show();
        }
      private void limparCampos()
        {
            cmbQtdMesa.Text = "";
            cmbNumeroMesa.Text = "";
            rtxtLanches.Clear();
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            somarValorPedido();
            limparCampos();
            new DetalhePedido().Show();

        }

        private void btnLanches_Click(object sender, EventArgs e)
        {
            new Lanches().Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            new Bebidas().Show();
        }
        private void somarValorPedido()
        {
           
            bd.SomarPedidos.ToList().ForEach(m =>
            {


                valores += m.Somar;

            });
           DetalhePedidoMesa pedidos = new DetalhePedidoMesa()
            {
                Numero_Mesa = cmbNumeroMesa.Text,
                Quantidade_Clientes = cmbQtdMesa.Text,
               Obs_Pedido = rtxtLanches.Text,
                Valor_Total = valores,
                Lanche = "x salada",
                Bebida = "coca cola"
                
                
            };
            bd.DetalhePedidoMesa.Add(pedidos);
            bd.SaveChanges();

            
        }
        private void excluirSoma()
        {
            
        }
       
    }
}
