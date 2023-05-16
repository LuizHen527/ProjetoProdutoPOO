using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgetoDeProdutos
{
    public class Marca
    {
        //Variaveis da classe Marca
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro;

        //Metodos da classe Marca
        public string Cadastrar(int Codigo, string NomeMarca, DateTime DataCadastro)
        {
        }

        public List<Marca> Listar()
        {
        }

        public string Deletar(int Codigo)
        {
        }
    }
}