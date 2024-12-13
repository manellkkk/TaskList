using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList.View.Grupos
{
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarGrupo editarGrupo = new EditarGrupo();
            editarGrupo.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarGrupo adicionarGrupo = new AdicionarGrupo();
            adicionarGrupo.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
