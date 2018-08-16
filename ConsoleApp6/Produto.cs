using System.Collections.Generic;

namespace ConsoleApp6
{
    partial class Program
    {
        public class Produto
        {
            public string Nome { get; set; }
            public Categoria Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }

            public override string ToString()
            {
                return $"produto {Nome} - {Categoria.Nome} preço: {Preco.ToString("N2")}";
            }

            public (int total, decimal valorTotal) CalcularBalanco()
            {
                //estoque maior que 10 aplica desconto
                //estoque menor que 3 aumenta o preco 

                return (Estoque, Preco * Estoque);
            }

            public IEnumerable<string> GetReviews(int total)
            {
                for (int i = 0; i < total; i++)
                {
                   yield return $"Review de exemplo {i}";
                }
            }
        }
    }
}
