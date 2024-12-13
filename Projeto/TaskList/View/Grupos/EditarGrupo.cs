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
    public partial class EditarGrupo : Form
    {
        public EditarGrupo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja editar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
