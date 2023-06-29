namespace TDMPW_411_2P_PR01;

public partial class Personaje2 : ContentPage
{
	public Personaje2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button temporal = (Button)sender;
        if ("👍" == temporal.Text)
        {
            this.respuesta2.Text = "Te gusto el personaje";
        }
        else
        {
            this.respuesta2.Text = "No te gusto el personaje";
        }
    }
}