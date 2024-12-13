using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskList.View.Grupos;
using TaskList.View.Tarefas;
using TaskList.View.Usuário;

namespace TaskList
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tarefas = new Tarefas();
            tarefas.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarTarefa adicionarTarefa = new AdicionarTarefa();
            adicionarTarefa.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Encerrar aplicação?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            GerenciarUsuario gerenciarUsuario = new GerenciarUsuario();
            gerenciarUsuario.Show();
        }
    }
}
