using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList.View.Usuário
{
    public partial class GerenciarUsuario : Form
    {
        public GerenciarUsuario()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}