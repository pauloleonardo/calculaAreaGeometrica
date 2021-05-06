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
    public partial class PageTrapezio : ContentPage
    {
        public PageTrapezio()
        {
            InitializeComponent();
        }
        private void btnAreaTrap(object sender, EventArgs e)
        {
            double bMenor = Double.Parse(txt_baseMenor.Text);
            double bMaior = Double.Parse(txt_baseMaior.Text);
            double h = Double.Parse(txt_altura.Text);
            double area = ((bMenor + bMaior) * h) / 2;

            resultado.Text = "A área do trapézio é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.DarkOrange;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}