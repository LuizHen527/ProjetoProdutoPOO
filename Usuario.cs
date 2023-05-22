using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgetoDeProdutos
{
    public class Usuario
    {
        //Variaveis da classe
        private int Codigo { get; set;}
        public string Nome { get; set; } = ""; //private
        public string Email { get; set; } = ""; //private
        public string Senha { get; set; } = ""; //private
        private DateTime DataCadastro;

        //Metodos da classe

        public void CadastrarUser(Usuario usuario)
        {
            Console.WriteLine($"Digite seu nome:");

            this.Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu Email:");
            
            this.Email = Console.ReadLine();
            
            Console.WriteLine($"Digite sua senha:");
            
            this.Senha = Console.ReadLine();
            
            Console.WriteLine($"Seu cadastro foi realizado com sucesso");
             
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