﻿using Escola.Exceptions;
using System.Collections.Generic;

namespace Escola.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public List<double> Notas { get; set; }
        public string Cpf { get; set; }

        public double Media()
        {
            double somaNotas = 0;
            foreach (var nota in this.Notas)
                somaNotas += nota;

            return somaNotas / this.Notas.Count;
        }

        public string Situacao()
        {
            return (this.Media() > 6 ? "Aprovado" : "Reprovado");
        }

        public string NotasFormadata()
        {
            return string.Join(",", this.Notas);
        }
    }
}
