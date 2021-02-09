using System;

namespace Juros.Business.Utils
{
    public static class DecimalExtensions
    {
        public static decimal Truncate(this decimal valor, int precisao)
        {
            // 1 - Calcula o fator multiplicador
            decimal fator = (decimal)Math.Pow(10, precisao);

            // 2 - Obtem o valor junto com a parte inteira desprezando os valores decimais restantes
            decimal valorTruncado = Math.Floor(valor * fator);

            // 3 - Agora divide pelo fator multiplicador para obter de volta
            // as casas decimais que foram parar na parte inteira (2)
            return Math.Floor(Math.Round(valorTruncado, precisao)) / fator;
        }
    }
}
