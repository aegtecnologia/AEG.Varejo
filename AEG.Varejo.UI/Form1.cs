using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEG.Varejo.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido ped = new Pedido();
            ped.Valor = 40;
            ped.PedidoId = 1;
            ped.Itens.Add(new PedidoItem()
            {
                Descricao = "bolo1",
                GrupoId = 1,
                PedidoId = 1,
                ProdutoId = 1,
                ValorUnitario = 7
            });
            ped.Itens.Add(new PedidoItem()
            {
                Descricao = "bolo2",
                GrupoId = 1,
                PedidoId = 1,
                ProdutoId = 1,
                ValorUnitario = 7
            });
            ped.Itens.Add(new PedidoItem()
            {
                Descricao = "bolo3",
                GrupoId = 1,
                PedidoId = 1,
                ProdutoId = 1,
                ValorUnitario = 7
            });
            //ped.Itens.Add(new PedidoItem()
            //{
            //    Descricao = "bolo4",
            //    GrupoId = 1,
            //    PedidoId = 1,
            //    ProdutoId = 1,
            //    ValorUnitario = 7
            //});
            //ped.Itens.Add(new PedidoItem()
            //{
            //    Descricao = "bolo5",
            //    GrupoId = 1,
            //    PedidoId = 1,
            //    ProdutoId = 1,
            //    ValorUnitario = 7
            //});
            ped.Itens.Add(new PedidoItem()
            {
                Descricao = "Refrigerante",
                GrupoId = 2,
                PedidoId = 1,
                ProdutoId = 1,
                ValorUnitario = 5
            });
            Promocao promocao = Promocao.Criar();
            Promocao.ValidaPromocao(ped, promocao);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(ped);
            textBox1.Text = json;

        }
    }
}
