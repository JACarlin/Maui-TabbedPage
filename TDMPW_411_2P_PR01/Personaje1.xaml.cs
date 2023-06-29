using Microsoft.Maui.Controls;

namespace TDMPW_411_2P_PR01;

public partial class Personaje1 : ContentPage
{
	public Personaje1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button temporal = (Button)sender;
		if ("👍" == temporal.Text)
		{
			this.respuesta.Text = "Te gusto el personaje";
		}
		else
		{
            this.respuesta.Text = "No te gusto el personaje";
        }

    }
}