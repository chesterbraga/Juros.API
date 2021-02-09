using System.Threading.Tasks;

namespace Juros.Business.Services
{
    public interface ITaxaJurosService
    {
        Task<double> GetTaxaJuros();
    }
}
