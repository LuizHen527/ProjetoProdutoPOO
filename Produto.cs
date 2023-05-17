using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string Cadastrar(Produto)
        {

        }

        public List<Produto> Listar()
        {
            
        }

        public string Deletar(Produto)
        {

        }
    }
}