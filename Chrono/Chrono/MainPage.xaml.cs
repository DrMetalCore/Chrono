using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chrono
{
	public partial class MainPage : ContentPage
	{
        bool stop = false;
        int sec = 0;
        int min = 0;

        public MainPage()
        {
            InitializeComponent();
            minutesLabel.Text = min.ToString();
            secLabel.Text = sec.ToString();

        }

        //CLICK SUR LE BOUTON START
        async void BoutonLancerChrono_Clicked(object sender, EventArgs e)
        {
            stop = false;
            while (stop != true)
            {
                await Task.Delay(1000);
                sec++;
                if (sec == 60)
                {
                    sec = 0;
                    min++;
                }
                minutesLabel.Text = min.ToString();
                secLabel.Text = sec.ToString();
            }
        }

        //CLICK SUR LE BOUTON STOP
        void BoutonStoperChrono_Clicked(object sender, EventArgs e)
        {
            stop = true;
        }

    }
}
