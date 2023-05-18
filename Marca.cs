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
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }

        //Metodos da classe Marca
        public void CadastrarMarca(Marca marca)
        {
            CultureInfo.CreateSpecificCulture("pt-BR");

            Console.WriteLine($"Digite o nome da marca:");
            this.NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"Digite o codigo da marca:");
            this.Codigo = int.Parse(Console.ReadLine());
            
            this.DataCadastro = DateTime.Now;

            Console.WriteLine($"{marca.DataCadastro}");
            
            
        }

        public List<Marca> ListarMarca()
        {
            List<Marca> productos = new List<Marca>();

            return productos;
        }

        public string DeletarMarca(int Codigo)
        {
            return "";
        }
    }
}