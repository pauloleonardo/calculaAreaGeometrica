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
    public partial class PageLosango : ContentPage
    {
        public PageLosango()
        {
            InitializeComponent();
        }
        private void btnAreaLos(object sender, EventArgs e)
        {
            double dMaior = Double.Parse(txt_dMaior.Text);
            double dMenor = Double.Parse(txt_dMenor.Text);
            double area = (dMaior * dMenor) / 2;

            resultado.Text = "A área do losango é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.DarkOrange;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}