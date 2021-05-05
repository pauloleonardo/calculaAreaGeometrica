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
    public partial class PageRectangle : ContentPage
    {
        public PageRectangle()
        {
            InitializeComponent();
        }
        private void btnAreaRet(object sender, EventArgs e)
        {
            double altura = Double.Parse(txt_h.Text);
            double baseRet = Double.Parse(txt_base.Text);
            double area = baseRet * altura;

            resultado.Text = "A área do retângulo é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.Black;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}