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
    public partial class PageSquare : ContentPage
    {
        public PageSquare()
        {
            InitializeComponent();
        }

        private void btnAreaQuad(object sender, EventArgs e)
        {
            double lado = Double.Parse(txt_lado.Text);
            double area = lado * lado;

            resultado.Text = "A área do quadrado é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.Black;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}