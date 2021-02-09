namespace Juros.Business.Services
{
    public interface ICalculoJurosService
    {
        decimal Calcular(decimal valorInicial, double taxa, int tempo);
        string ShowMeTheCode();        
    }
}