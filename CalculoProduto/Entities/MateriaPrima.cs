﻿namespace CalculoProduto.Entities
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Qnts { get; set; }
        public double Valor { get; set; }

        public MateriaPrima() { }

        public MateriaPrima(string nome, double qnts, double valor )
        {
            Nome = nome;
            Qnts = qnts;
            Valor = valor;
        }
    }
}
