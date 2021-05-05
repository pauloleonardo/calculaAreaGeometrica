using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculaAreaGeometrica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(vi)))
        }

        /*private async void BtnPageSemMenuAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageSemMenu());
        }
        private async void BtnPageComMenu(object sender, EventArgs e)
        {

        }*/
        private async void BtnSquare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageSquare());
        }
        private async void BtnCircle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageCircle());
        }
        private async void BtnTriagle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageTriangle());
        }
        private async void BtnRectangle(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageRectangle());
        }
        private async void BtnLosango(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageLosango());
        }
        private async void BtnTrapezio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.PageTrapezio());
        }

    }
}
