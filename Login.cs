using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgetoDeProdutos
{
    public class Login
    {

        private bool Logado { get; set; }

        public Login()
        {
            //Variaveis
            string opcao;
            string opcaoLogin;
            bool loop = true;
            bool loopLogin = true;

            //Objetos

            Usuario user = new Usuario();

            //Logica

            //Primeira parte - Login

            // do
            // {
            //     Console.WriteLine($@"
            // Digite (1) para fazer login;
            //        (2) para fazer cadastrar novo usuario;
            //        (0) para finalizar programa.");

            //     opcao = Console.ReadLine();

            //     switch (opcao)
            //     {
            //         case "1":
            //             Console.WriteLine($"{this.Logar(user)}");
            //             loop = true;
            //             break;

            //         case "2":
            //             user.CadastrarUser(user);
            //             loop = true;
            //             break;

            //         case "0":
            //             Console.WriteLine($"Programa encerrado");
            //             loop = false;
            //             goto case "4";

            //         case "4":
            //             Console.WriteLine($"Estamos progredindo. Digita qualquer coisa:");
            //             Console.ReadLine();
            //             break;
            //         default:
            //             break;
            //     }
            // } while (loop);

            //---------------------------------------------------

                opcao = "1";

            do
            {

                switch (opcao)
                {
                    
                    case "1":

                    //Parte do Login

                    do
                    {
                        Console.WriteLine($@"
                    Digite (1) para fazer login;
                           (2) para fazer cadastrar novo usuario;
                           (0) para finalizar programa.");

                        opcaoLogin = Console.ReadLine();

                        switch (opcaoLogin)
                        {
                            case "1":
                                Console.WriteLine($"{this.Logar(user)}");
                                loopLogin = true;
                                break;

                            case "2":
                                user.CadastrarUser(user);
                                loopLogin = true;
                                break;

                            case "0":
                                loopLogin = false;
                                opcao = "0";
                                break;

                            case "4":
                                Console.WriteLine($"Estamos progredindo. Digita qualquer coisa:");
                                Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                    } while (loopLogin);

                    break;

                    //Parte do menu

                    case "2":
                        user.CadastrarUser(user);
                        loop = true;
                        break;

                    case "0":
                        Console.WriteLine($"Programa encerrado");
                        loop = false;
                        break;;

                    case "4":
                        Console.WriteLine($"Estamos progredindo. Digita qualquer coisa:");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (loop);

            //Segunda parte - Menu



        }

        public string Logar(Usuario usuario)
        {
            //Variaveis
            bool loop = true;

            //Logica

            do
            {
                Console.WriteLine($"Digite seu nome ou Email:");
                string nomeEmail = Console.ReadLine();

                Console.WriteLine($"Digite sua senha:");
                string senha = Console.ReadLine();

                if (usuario.Email == "" && usuario.Senha == "")
                {
                    return "Para logar e preciso cadastrar um usuario";
                }

                else if (((nomeEmail == usuario.Nome) || (nomeEmail == usuario.Email)) && senha == usuario.Senha)
                {
                    Logado = true;

                    loop = false;

                    return "Login executado com sucesso";
                }


                else
                {
                    Logado = false;

                    loop = true;

                    return "Usuario ou senha incorreto";
                }
            } while (loop);




        }

        public string Deslogar(Usuario usuario)
        {
            return "";
        }
    }
}