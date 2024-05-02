namespace VIEWS
{
	public partial class frmMenu : Form
	{
		private frmLogin frmLogin;
		public frmMenu(frmLogin frmLogin)
		{
			InitializeComponent();

			this.frmLogin = frmLogin;
			this.MaximizeBox = false;
			FormClosed += (sender, e) => { Fechar(); };
		}

		private void Fechar()
		{
			frmLogin.Show();
		}
	}
}
