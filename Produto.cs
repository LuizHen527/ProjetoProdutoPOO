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

        private int Codigo { get; set; }
        public string NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro;
        public Marca marca { get; set; }
        private string CadastradoPor { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }

        //Metodos

        public string Cadastrar(Produto produto, List<Marca> marcas, Usuario user)
        {
            Console.WriteLine($"Digite o nome do produto:");
            produto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o codigo do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            if (marcas != null)
            {
                Console.WriteLine($"Deseja cadastrar uma marca? Precione enter para cadastrar marca, escreva 'n' para cadastrar sem marca");
                string opcao = Console.ReadLine();

                if (opcao == "")
                {
                    Console.WriteLine($"Digite o codigo da marca desse produto:");
                    int procuraMarca = int.Parse(Console.ReadLine());

                    produto.marca = marcas.Find(x => x.Codigo == procuraMarca);
                }
            }

            this.DataCadastro = DateTime.Now;

            this.CadastradoPor = user.Nome;

            return "Cadastro realizado com sucesso";
        }

        public void Listar(List<Produto> produtos)
        {
            if (produtos == null)
            {
                Console.WriteLine($"Os produtos não foram encontrados");
            }
            else
            {
                Console.WriteLine($"Produtos cadastrados:");
                
                foreach (var item in produtos)
                {
                    Console.WriteLine($@"
Nome: {item.NomeProduto}
Preço: {item.Preco}

                    ");
                    
                }
            }
        }

        public string Deletar(Produto produto)
        {
            return "";
        }
    }
}