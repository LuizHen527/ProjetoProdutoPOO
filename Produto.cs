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

        public string Cadastrar(Produto produto)
        {
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