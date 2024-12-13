using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList.View.Tarefas
{
    public partial class Tarefas : Form
    {
        public Tarefas()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarTarefa adicionarTarefa = new AdicionarTarefa();
            adicionarTarefa.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTarefa editarTarefa = new EditarTarefa();
            editarTarefa.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
