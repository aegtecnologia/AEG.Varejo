using AEG.Varejo.Domain.Contratos.Servicos;
using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Service.Services;
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
    public partial class frmUsuarioConsulta : Form
    {
        IUsuarioService servico;

        public frmUsuarioConsulta()
        {
            InitializeComponent();
        }

        void ListarUsuarios()
        {
            var lista = servico.ListarTodos().ToList();

            dataGridView1.Rows.Clear();

            foreach (var u in lista)
            {
                dataGridView1.Rows.Add(u.UsuarioId, $"{u.UsuarioId} | {u.Nome} | {u.Email}");
            }
        }

        private void frmUsuarioConsulta_Load(object sender, EventArgs e)
        {
            servico = new UsuarioService();
            ListarUsuarios();
        }

        void AbrirCadastro(Usuario usuario)
        {
            frmUsuarioCadastro cad = new frmUsuarioCadastro(usuario);
            cad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirCadastro(new Usuario());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            int usuarioId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            Usuario usuario = servico.BuscarPorId(usuarioId);

            AbrirCadastro(usuario);
        }
    }
}
