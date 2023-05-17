using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgetoDeProdutos
{
    public class Login
    {

        private bool Logado{ get; set; }

        public Login()
        {
        }

        public string Logar(Usuario usuario)
        {

            do
            {
                Console.WriteLine($"Digite seu nome ou Email:");
                string nomeEmail = Console.ReadLine();
                
                Console.WriteLine($"Digite sua senha:");
                string senha = Console.ReadLine();

                if (nomeEmail == usuario.Nome)
                {
                    
                }
            } while (true);
        }

        public string Deslogar(Usuario)
        {

        }
    }
}