namespace TaskList
{
    public partial class JanelaLogin : Form
    {
        public JanelaLogin()
        {
            InitializeComponent();
        }
        private void app()
        {
            Application.Run(new TelaPrincipal());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread;
            thread = new Thread(app);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblCadastrar_Click_1(object sender, EventArgs e)
        {
            CadastroUsuario jan = new CadastroUsuario();
            jan.Show();
        }

        private void lblCadastrar_MouseEnter(object sender, EventArgs e)
        {
            lblCadastrar.Cursor = Cursors.Hand;
        }
    }
}
