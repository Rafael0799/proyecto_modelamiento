using System;
using Xunit;
using CalculadoraContaminacionRios.Services;

namespace CalculadoraContaminacionRios.Tests
{
    public class IntegrationServiceTests
    {
        private readonly IntegrationService _integrationService;

        public IntegrationServiceTests()
        {
            _integrationService = new IntegrationService();
        }

        [Fact]
        public void IntegracionTrapecio_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double a = 0;
            double b = 10;
            int n = 100;
            Func<double, double> function = x => x * x; // Example function: f(x) = x^2

            // Act
            double result = _integrationService.IntegracionTrapecio(function, a, b, n);

            // Assert
            double expected = (b * b * b / 3) - (a * a * a / 3); // Expected result for f(x) = x^2
            Assert.Equal(expected, result, 5); // Allowing a precision of 5 decimal places
        }

        [Fact]
        public void IntegracionSimpson_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double a = 0;
            double b = 10;
            int n = 100; // n must be even for Simpson's rule
            Func<double, double> function = x => x * x; // Example function: f(x) = x^2

            // Act
            double result = _integrationService.IntegracionSimpson(function, a, b, n);

            // Assert
            double expected = (b * b * b / 3) - (a * a * a / 3); // Expected result for f(x) = x^2
            Assert.Equal(expected, result, 5); // Allowing a precision of 5 decimal places
        }
    }
}