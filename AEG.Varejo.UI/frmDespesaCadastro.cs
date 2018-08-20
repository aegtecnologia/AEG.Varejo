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
using Newtonsoft.Json;
using AEG.Varejo.Domain.Validations;
using AEG.Varejo.Domain.Contratos.Servicos;
using AEG.Varejo.Service.Services;

namespace AEG.Varejo.UI
{
    public partial class frmDespesaCadastro : Form
    {

        Despesa despesa;

        ICentroCustoService ccService;

        public frmDespesaCadastro()
        {
            InitializeComponent();
        }

        private void frmDespesaCadastro_Load(object sender, EventArgs e)
        {
            despesa = new Despesa();
            ccService = new CentroCustoService();
            CarregaCboCcusto();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void CarregaCboCcusto()
        {
            try
            {
                var lista = ccService.BuscarTodos().ToList();
                cboCCusto.DataSource = lista;
                cboCCusto.DisplayMember = "Descricao";
                cboCCusto.ValueMember = "CentroCustoId";
                cboCCusto.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        void Validar()
        {
            try
            {
                despesa.Validar();           
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }         
        }

       

        private void txtBruto_Validating(object sender, CancelEventArgs e)
        {
            decimal bruto;

            if (!decimal.TryParse(txtBruto.Text, out bruto))
            {
                txtBruto.Text = "";
                   e.Cancel = true;
            }
                        
        }

        private void txtBruto_Validated(object sender, EventArgs e)
        {
            decimal bruto;

            if (decimal.TryParse(txtBruto.Text, out bruto))
            {
                txtBruto.Text = bruto.ToString("0.00");
                despesa.ValorBruto = Convert.ToDecimal( bruto.ToString("0.00"));
            }

            MontaJSON();
        }

        private void MontaJSON()
        {
            txtTotal.Text = despesa.ValorLiquido.ToString("0.00");
            var json = JsonConvert.SerializeObject(despesa);
            txtJson.Text = json;
        }

        private void txtDesc_Validated(object sender, EventArgs e)
        {
            despesa.Descricao = txtDesc.Text;
            MontaJSON();
        }

        private void dtpVencimento_Validated(object sender, EventArgs e)
        {
            despesa.DataVencimento = dtpVencimento.Value;
            MontaJSON();
        }

        private void txtDesconto_Validated(object sender, EventArgs e)
        {
            decimal desconto;

            if (!decimal.TryParse(txtDesconto.Text, out desconto))
                desconto = 0;

            txtDesconto.Text = desconto.ToString("0.00");

            despesa.ValorDesconto = Convert.ToDecimal(desconto.ToString("0.00"));
            MontaJSON();
        }

        private void txtAcrescimo_Validated(object sender, EventArgs e)
        {
            decimal acresc;

            if (!decimal.TryParse(txtAcrescimo.Text, out acresc))
                acresc = 0;

            txtAcrescimo.Text = acresc.ToString("0.00");

            despesa.ValorAcrescimo = Convert.ToDecimal(acresc.ToString("0.00"));
            MontaJSON();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
