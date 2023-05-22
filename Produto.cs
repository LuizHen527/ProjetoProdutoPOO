using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgetoDeProdutos
{
    public class Produto
    {
        //Variaveis

        private int Codigo{ get; set;}
        private string NomeProduto{ get; set;}
        private float Preco{ get; set;}
        private DateTime DataCadastro;
        public Marca marca{ get; set; }
        private Usuario CadastradoPor;
        private List<Produto> ListaDeProdutos{ get; set;}

        //Metodos

        public string Cadastrar(Produto produto, List<Marca> marcas)
        {
            Console.WriteLine($"Digite o nome do produto:");
            produto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o codigo do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o codigo da marca desse produto:");
            int procuraMarca = int.Parse(Console.ReadLine());
            
            produto.marca = marcas.Find(x => x.Codigo == procuraMarca);

            return "";
        }

        public List<Produto> Listar()
        {
            List<Produto> productos = new List<Produto>();

            return productos;
        }

        public string Deletar(Produto produto)
        {
            return "";
        }
    }
}