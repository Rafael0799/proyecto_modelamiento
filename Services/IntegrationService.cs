using System;

namespace CalculadoraContaminacionRios.Services
{
    public class IntegrationService
    {
        public double IntegracionTrapecio(Func<double, double> funcion, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = 0.5 * (funcion(a) + funcion(b));

            for (int i = 1; i < n; i++)
            {
                suma += funcion(a + i * h);
            }

            return suma * h;
        }

        public double IntegracionSimpson(Func<double, double> funcion, double a, double b, int n)
        {
            if (n % 2 != 0)
            {
                throw new ArgumentException("El número de intervalos n debe ser par para la regla de Simpson.");
            }

            double h = (b - a) / n;
            double suma = funcion(a) + funcion(b);

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    suma += 2 * funcion(a + i * h);
                }
                else
                {
                    suma += 4 * funcion(a + i * h);
                }
            }

            return suma * (h / 3);
        }
    }
}