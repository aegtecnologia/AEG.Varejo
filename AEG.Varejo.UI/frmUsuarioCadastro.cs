using AEG.Varejo.Domain.Contratos.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Service.Services;

namespace AEG.Varejo.UI
{
    public partial class frmUsuarioCadastro : Form
    {
        IUsuarioService servico;
        Usuario usuario;

        public frmUsuarioCadastro(Usuario _usuario)
        {
            servico = new UsuarioService();
            usuario = _usuario;
            InitializeComponent();
        }

        void ImportarDados()
        {
            txtEmail.Text = usuario.Email;
            txtNome.Text = usuario.Nome;
            txtSenha.Text = usuario.Senha;
        }

        void ExportarDados()
        {
            usuario.Email = txtEmail.Text;
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
        }

        void Salvar()
        {
            ExportarDados();
            servico.NovoCadastro(usuario);
        }

        private void frmUsuarioCadastro_Load(object sender, EventArgs e)
        {
            ImportarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
