using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon.Domain.Model
{
    class Calculo
    {
        Funcionario Funcionario { get; set; }

        public Calculo(Funcionario funcionario)
        {
            Funcionario = funcionario ?? throw new ArgumentException("Entidade Funcionário não existente");
        }

        public double CalcularSalarioBruto(double valorHora, double horasTrabalhadas)
        {
            double salarioBruto = valorHora * horasTrabalhadas;
            return salarioBruto;
        }
    }
}
