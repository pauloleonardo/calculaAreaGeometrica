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
    public partial class PageTriangle : ContentPage
    {
        public PageTriangle()
        {
            InitializeComponent();
        }

        private void btnAreaTri(object sender, EventArgs e)
        {
            double lado1Base = Double.Parse(txt_lado1.Text);
            double h = Double.Parse(txt_altura.Text);
            //double lado3 = Double.Parse(txt_lado3.Text);
            double area = ((lado1Base * h)/2);
            //double altura = 0.0;

            /*if (lado3>lado1+lado2 || lado1>lado2+lado3 || lado2>lado1+lado3)
            {
                resultado.Text = "Não é um triângulo, entre com valores válidos! A soma de dois lados tem que ser maior que um dos lados";
                resultado.TextColor = Color.Red;
                resultado.HorizontalTextAlignment = TextAlignment.Center;
            }else if (lado3 < lado1 + lado2 || lado1 < lado3 + lado2 || lado2 < lado1 + lado3)
            {
                if(lado1 == lado2 && lado2 == lado3)
                {
                    area = ((lado2 * lado2) * Math.Sqrt(3) / 3);
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    if(lado1 == lado2)
                    {
                        
                    }else if (lado2 == lado3)
                    {

                    }else if(lado3 == lado1)
                    {

                    }
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                {

                }
            }*/

            resultado.Text = "A área do triângulo é: " + area.ToString(("0.00"));
            resultado.TextColor = Color.DarkOrange;
            resultado.HorizontalTextAlignment = TextAlignment.Center;
        }
    }
}