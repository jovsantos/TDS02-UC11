namespace UtilitariosApp
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Divisao(double a, double b)
        {
            if (b == 0)
            {
                return (int)a; // Retorna o dividendo se o divisor for zero
            }

            var resultado = a / b;
            return (int)Math.Ceiling(resultado);
        }


    }
}
