namespace VIEWS
{
	public partial class frmUsuario : Form
	{
		public frmUsuario()
		{
			InitializeComponent();
			btnSair.Click += (sender, e) => { this.Close(); };
		}
	}
}
