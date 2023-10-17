using Model.Operacoes.Calculadora;
using Calculadora.Util;
namespace CalculadoraTest
{
    public class TestCalculadora
    {
        private readonly OperacoesCalculadora _calculadora;


        public TestCalculadora()
        {
            _calculadora = new OperacoesCalculadora();
        }

      
        [Theory]
        [InlineData(1,2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 4, 5)]
        public void DeveSomarDoisValoresERetornarASomaEntreEles(int valor1, int valor2, int valorEsperado)
        {

            //Act
            var resultado = _calculadora.Somar(valor1, valor2);

            //Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 3, 3)]
        [InlineData(1, 4, 4)]
        public void DeveMultiplicarDoisValoresERetornarOResultadoEntreEles(int valor1, int valor2, int valorEsperado)
        {

            //Act
            var resultado = _calculadora.Multiplicar(valor1, valor2);
          
            //Assert

            Assert.Equal(valorEsperado, resultado);
        }

        [Theory]
        [InlineData(0, 0)]
        public void DeveRetornarUmaExcecaoCasoHajaDivisaoPorZero(int valor1, int valor2)
        {
            //Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(valor1, valor2));
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(6, 3, 2)]
        public void DeveDividirDoisValoresERetornarOResultadoEntreEles(int valor1, int valor2, int valorEsperado)
        {

            //Act
            var resultado = _calculadora.Dividir(valor1, valor2);

            //Assert

            Assert.Equal(valorEsperado, resultado);
        }


        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, 3, 2)]
        public void DeveSubtrairDoisValoresERetornarOResultadoEntreEles(int valor1, int valor2, int valorEsperado)
        {

            //Act
            var resultado = _calculadora.Subtrair(valor1, valor2);
            

            //Assert
            Assert.Equal(valorEsperado, resultado);
           
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(5, 3)]
        public void HistoricoDeveTerAteDoisValoresSalvos(int valor1, int valor2)
        {
            //Arrange
            int ValorMaximo = 2;
            var lista = _calculadora.RetornaLista();


            //Act
            var resultado = Util.ConverteParaString(_calculadora.Somar(valor1, valor2));
           
            lista.Add(resultado);
            var countLista = lista.Count();
            //Assert

            Assert.Equal(ValorMaximo, countLista);
        }


    }
}