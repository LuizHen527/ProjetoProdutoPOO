using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgetoDeProdutos
{
    public class Usuario
    {
        //Variaveis da classe
        private int Codigo{ get; set;}
        private string Nome{ get; set;}
        private string Email{ get; set;}
        private string Senha{ get; set;}
        private DateTime DataCadastro;

        //Metodos da classe

        public string CadastrarUser(Usuario usuario)
        {
            Console.WriteLine($"Digite seu nome:");

            this.Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu Email:");
            
            this.Email = Console.ReadLine();
            
            Console.WriteLine($"Digite sua senha:");
            
            this.Senha = Console.ReadLine();
            
            return "Seu cadastro foi realizado com sucesso";
        }

        public string DeletarUser(Usuario usuario)
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";

            return "Usuario deletado";
        }
    }
}