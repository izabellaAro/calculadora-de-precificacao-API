﻿namespace CalculoProduto.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Preparacao> Preparacoes { get; set; } = new List<Preparacao>();

        public Produto()
        {
            
        }
        public Produto(string nome)
        {
            Nome = nome;
            //Preparacoes.Add(preparacao);
        }

    }
}
