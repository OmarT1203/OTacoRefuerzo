namespace OTacoRefuerzo.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioLogin = txtUsuario.Text;
			Navigation.PushAsync(new vDos(usuarioLogin));
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error " + ex.Message);
		}
    }
}