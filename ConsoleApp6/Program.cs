using System;

namespace ConsoleApp6
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Yield
            var produto = new Produto();
            var totalReviews = 10;
            var reviews = produto.GetReviews(totalReviews);
            foreach (var review in reviews)
            {
                Console.WriteLine(review);
            }

            #region Tuplas

            ////Tuplas
            //var produto = new Produto() { Preco = 39.90M, Estoque = 30 };

            //var (total, valorTotal) = produto.CalcularBalanco();

            //Console.WriteLine(total);
            //Console.WriteLine(valorTotal);


            //var result = produto.CalcularBalanco();

            //var total = result.total;
            //var valorTotal = result.valorTotal;
            #endregion

            #region null conditional

            ////null-conditional operator (safe navigation operator)

            //var produto = new Produto()
            //{
            //    Nome = "Get Start ASP.NET Core",
            //    Categoria=new Categoria() { Nome="Livros"},
            //    Preco = 39.90M
            //};

            //Console.WriteLine(produto.Categoria?.Nome ??"sem categoria"); //=>null

            //if (produto.Categoria != null )
            //    Console.WriteLine(produto.Categoria.Nome);
            //else
            //    Console.WriteLine("sem categoria");

            #endregion

            #region Out Variables
            //Out Variables
            //var ano = "1989";


            //if (int.TryParse(ano, out int anoConvertido))
            //{
            //    Console.WriteLine(anoConvertido);
            //}

            //Console.WriteLine(anoConvertido);


            //DateTime.TryParse("22-22-1989", out DateTime data);

            //Console.WriteLine(data);

            #endregion

            #region Interpolation

            ////String Interpolation
            //var produto = new Produto()
            //{
            //    Nome = "Get Start ASP.NET Core",
            //    Categoria = "Livro",
            //    Preco = 39.90M
            //};

            //var prod = "produto " + produto.Nome + " - " + produto.Categoria + " preço:" + produto.Preco;
            //var prod2 = string.Format("produto {0} - {1} preço: {2}", produto.Nome, produto.Categoria, produto.Preco);
            //var prod3 = $"produto {produto.Nome} - {produto.Categoria} preço: {produto.Preco.ToString("N2")}";


            //Console.WriteLine(produto);
            #endregion

        }
    }
}
