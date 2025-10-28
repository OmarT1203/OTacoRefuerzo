namespace OTacoRefuerzo.Vistas;

public partial class vDos : ContentPage
{
	public vDos(string usuario)
	{
		InitializeComponent(); //
		DisplayAlert("Bienvenida", "Bienvenido" + usuario, "Cerrar");
		lblUsuario.Text = "USUARIO CONECTADO " + usuario;
	}

    private void btnEnviar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string nombre = txtNombre.Text;
			int edad = Convert.ToInt32(txtEdad.Text);
			string fecha = dpFecha.Date.ToString();
			Navigation.PushAsync(new vTres(nombre, edad, fecha));
		}
		catch (Exception)
		{

			throw;
		}
    }
}