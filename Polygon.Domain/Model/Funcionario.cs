using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon.Domain.Model
{
    class Funcionario
    {
        public int Matricula { get; }
        public double ValorHora { get; }
        public double HorasTrabalhadas { get; }

        public Funcionario(int matricula, double valorHora, double horasTrabalhadas)
        {
            if (matricula < 0)
            {
                throw new ArgumentException("O parametro matricula é inválido.!");
            }

            if (valorHora < 0)
            {
                throw new ArgumentException("O parametro de valor hora é inválido.!");
            }

            if (horasTrabalhadas < 0)
            {
                throw new ArgumentException("O parametro de horas trabalhadas é inválido.!");
            }

            Matricula = matricula;
            ValorHora = valorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }
    }
}
