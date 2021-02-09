using Juros.Business.Utils;
using System;

namespace Juros.Business.Services
{
    public class CalculoJurosService: ICalculoJurosService
    {
        public decimal Calcular(decimal valorInicial, double taxa, int tempo)
        {            
            decimal calculo = valorInicial * (decimal)Math.Pow(1 + taxa, tempo);
            return calculo.Truncate(2);
        }

        public string ShowMeTheCode()
        {
            return "https://github.com/chesterbraga/Softplan.API";
        }
    }
}