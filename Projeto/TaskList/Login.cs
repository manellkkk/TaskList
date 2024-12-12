namespace TaskList
{
    public partial class JanelaLogin : Form
    {
        public JanelaLogin()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }

        private void lblCadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastro jan = new Cadastro();
            jan.Show();
        }

        private void lblCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrar.Cursor = Cursors.Hand;
        }
    }
}
