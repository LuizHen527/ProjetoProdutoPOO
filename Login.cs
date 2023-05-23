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
            string opcao = "1";
            string opcaoLogin;
            string opcaoMenu;
            bool loop = true;
            bool loopLogin = true;
            bool loopMenu = true;

            //Objetos

            Usuario user = new Usuario();

            //Logica

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

                                    string validacao;

                                    Console.WriteLine($"{validacao = this.Logar(user)}");

                                    if (validacao == "Para logar e preciso cadastrar um usuario")
                                    {
                                        loopLogin = true;
                                    }

                                    else if (validacao == "Login executado com sucesso")
                                    {
                                        loopLogin = false;
                                        opcao = "2";
                                    }

                                    break;

                                case "2":
                                    user.CadastrarUser(user);
                                    loopLogin = true;
                                    break;

                                case "0":
                                    loopLogin = false;
                                    opcao = "0";
                                    break;
                                default:
                                    Console.WriteLine($"Digite uma opção valida");
                                    loopLogin = true;
                                    break;
                            }
                        } while (loopLogin);

                        break;

                    //--------------------------------------------------------------------------------------------------------------

                    //Parte do menu principal

                    case "2":

                        //Coisas uteis para esse menu

                        List<Marca> marcas = new List<Marca>();
                        List<Produto> produtos = new List<Produto>();

                        do
                        {
                            Console.WriteLine($@"
Digite (1) para alterar produtos;
       (2) para alterar marcas;
       (0) para encerrar programa.");

                            opcaoMenu = Console.ReadLine();

                            switch (opcaoMenu)
                            {
                                case "1":

                                //Cadastro de Produtos

                                    Console.WriteLine($@"
Digite (1) para cadastrar novo produto;
       (2) para listar produtos;
       (3) para remover produto;
       (0) para voltar ao menu principal.");

                                    string menuProdutos = Console.ReadLine();

                                    switch (menuProdutos)
                                    {
                                        //Cadastrar produtos

                                        case "1":
                                            Produto novoProduto = new Produto();
                                            
                                            novoProduto.Cadastrar(novoProduto, marcas, user);

                                            produtos.Add(novoProduto);

                                            Console.WriteLine($@"
Novo produto criado com sucesso.");
                                            break;

                                        //Listar produtos

                                        case "2":
                                            

                                            break;

                                        default:
                                            break;
                                    }

                                    break;

                                //Cadastro de marcas

                                case "2":
                                    bool loopMarcas = true;
                                    do
                                    {
                                        Console.WriteLine($@"
Digite (1) para cadastrar nova marca;
       (2) para listar marcas;
       (3) para remover marca;
       (0) para voltar ao menu principal.");

                                        string menuMarcas = Console.ReadLine();

                                        switch (menuMarcas)
                                        {

                                            //Cadastrar nova marca

                                            case "1":
                                                Marca novaMarca = new Marca();

                                                novaMarca.CadastrarMarca(novaMarca, user);

                                                marcas.Add(novaMarca);

                                                Console.WriteLine($@"
Cadastro realizado");
                                                break;

                                            //Listar marcas

                                            case "2":
                                                Marca.ListarMarca(marcas);
                                                break;

                                            // Deletar marcas

                                            case "3":
                                                Console.WriteLine(Marca.DeletarMarca(marcas));
                                                break;

                                            case "0":
                                                loopMarcas = false;
                                                break;

                                            default:
                                                break;
                                        }
                                    } while (loopMarcas);


                                    break;

                                default:
                                    break;
                            }


                        } while (loopMenu);

                        loop = true;
                        break;

                    case "0":
                        Console.WriteLine($"Programa encerrado");
                        loop = false;
                        break;

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
                if (usuario.Email == "" && usuario.Senha == "")
                {
                    return "Para logar e preciso cadastrar um usuario";
                }

                Console.WriteLine($"Digite seu nome ou Email:");
                string nomeEmail = Console.ReadLine();

                Console.WriteLine($"Digite sua senha:");
                string senha = Console.ReadLine();

                if (((nomeEmail == usuario.Nome) || (nomeEmail == usuario.Email)) && senha == usuario.Senha)
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