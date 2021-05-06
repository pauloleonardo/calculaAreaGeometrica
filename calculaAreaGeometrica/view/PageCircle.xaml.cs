using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculaAreaGeometrica.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCircle : ContentPage
    {
        public PageCircle()
        {
            InitializeComponent();
        }
        private void btnAreaCircle( object sender, EventArgs e){
            double raio = Double.Parse(txt_raio.Text);
            double area = 3.14159265358 * raio * raio;

            resultado.Text = "A área do círculo é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.DarkOrange;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}