using Microsoft.VisualStudio.TestTools.UnitTesting;
using Juros.Business.Services;

namespace Juros.Tests
{
    [TestClass]
    public class CalculoJurosTests
    {        
        private const string _gitHub = "https://github.com/chesterbraga/Juros.API";
        private ICalculoJurosService _calculoJurosService;

        [TestInitialize]
        public void Init()
        {
            _calculoJurosService = new CalculoJurosService();
        }        

        [TestMethod]        
        public void TesteCalculoJuros()
        {
            decimal juros = _calculoJurosService.Calcular(100.00m, 0.01, 5);
            Assert.AreEqual(105.10m, juros, "Juros");
        }

        [TestMethod]        
        public void ShowMeTheCode()
        {
            string gitHub = _calculoJurosService.ShowMeTheCode();
            Assert.AreEqual(_gitHub, gitHub, "Show me the code");
        }        
    }
}