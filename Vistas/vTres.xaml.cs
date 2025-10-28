namespace OTacoRefuerzo.Vistas;

public partial class vTres : ContentPage
{
	public vTres(string nombre, int edad, string fecha)
	{
		InitializeComponent();
		txtnombre.Text = nombre;
		txtEdad.Text = edad.ToString();
		txtFecha.Text = fecha;
	}

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vLogin());
    }
}