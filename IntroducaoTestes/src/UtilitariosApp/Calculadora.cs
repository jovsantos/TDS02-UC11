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

        public int SubtrairPositivoOuZero(int a, int b)
        {
            if (b > a)
            {
                return 0; // Retorna zero se o resultado da subtração for negativo
            }
            return a - b;   
        }

        public double PotenciaDeUmNumero(int @base, int expoente) 
        {
            return Math.Pow(@base, expoente);
        }

        public double Raiz(int a)
        {

            if (a < 0) 
            {
                throw new ArgumentException("Não é possivel calcular raiz de 0 ou negativo");
            }
            return Math.Sqrt(a);
        }

    }
}
