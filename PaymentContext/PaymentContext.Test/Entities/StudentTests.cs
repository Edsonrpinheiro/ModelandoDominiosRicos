using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Test
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var studant = new Student("Edson", "Rodrigues Pinheiro", "42530880824", "edson@ecliente.com.br");
        }
    }
}
