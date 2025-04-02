using System;

namespace CalculadoraContaminacionRios.Services
{
    public class ContaminacionService
    {
        public double CalcularContaminacion(double concentracion, double velocidad, double tiempo)
        {
            // Implement business logic for calculating contamination based on concentration, velocity, and time
            return concentracion * velocidad * tiempo;
        }

        public string ObtenerResultados(double contaminacion)
        {
            // Implement logic to interpret contamination results and return a message
            if (contaminacion < 10)
            {
                return "Niveles de contaminación aceptables.";
            }
            else if (contaminacion < 50)
            {
                return "Niveles de contaminación moderados.";
            }
            else
            {
                return "Niveles de contaminación altos. Se requiere atención inmediata.";
            }
        }
    }
}