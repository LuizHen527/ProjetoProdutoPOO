using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgetoDeProdutos
{
    public class Marca
    {
        //Variaveis da classe Marca
        public int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }
        private string NomeUser { get; set; }
        private static int NumeroMarcas;

        //Metodos da classe Marca
        public void CadastrarMarca(Marca marca, Usuario user)
        {
            CultureInfo.CreateSpecificCulture("pt-BR");

            Console.WriteLine($"Digite o nome da marca:");
            this.NomeMarca = Console.ReadLine();

            Console.WriteLine($"Digite o codigo da marca:");
            this.Codigo = int.Parse(Console.ReadLine());

            this.DataCadastro = DateTime.Now;

            this.NomeUser = user.Nome;

            Marca.NumeroMarcas++;

        }

        public static void ListarMarca(List<Marca> marcas)
        {
            if (Marca.NumeroMarcas == 0)
            {
                Console.WriteLine($"Nenhuma marca encontrada");
            }
            else
            {
                Console.WriteLine($"Marcas cadastradas:");

                foreach (var item in marcas)
                {
                    Console.WriteLine($@"
Nome da marca: {item.NomeMarca}
Codigo da marca: {item.Codigo}
Data do cadastro: {item.DataCadastro}
Cadastro feito por {item.NomeUser}");
                }
            }

        }

        public static string DeletarMarca(List<Marca> marcas)

        {
            if (Marca.NumeroMarcas == 0)
            {
                return"Nenhuma marca encontrada";
            }
            else
            {
                Console.WriteLine($@"
Digite a marca que deseja deletar.
Marcas cadastradas:");
                
            foreach (var item in marcas)
            {
                Console.WriteLine($@"
Nome da marca: {item.NomeMarca}
Para deletar digite {marcas.IndexOf(item)}
                ");
            }

            int index = int.Parse(Console.ReadLine());

            marcas.RemoveAt(index);

            Marca.NumeroMarcas--;

            return "Marca removida com sucesso";
            }
        }
    }
}