using System;

namespace SistemaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {   
                Console.Write("Sistema de Passagens \n\n");
                string senha;
                string usuarios = "Passageiros cadastrados:\n";

            do{
                Console.WriteLine("digite sua senha");
                senha = Console.ReadLine();
            } while (Login());

            do {
                Console.Write(" Menu de acesson\n- Digite 0 para sair\n- Digite 1 para cadastrar passagens\n- Digite 2 para listar passagens\n");
            } while (Menu(Console.ReadLine()));


            bool Login () {
                if (senha == "123456"){
                    return false;
                } else {
                    Console.WriteLine("Senha incorreta");
                    return true;
                }
            }
            bool Menu(string a) {
                switch (a)
                {
                    case "0":
                        Console.WriteLine("saindo do sistema");
                        return false;
                    case "1":
                        Cadastro();
                        return true;
                    case "2":
                    Console.Write(usuarios);
                        return true;
                    default:
                        Console.WriteLine("valor inválido");
                        return true;
                }
                
            }
            void Cadastro(){
                string denovo;
                do { // Não foi pedido que letras minusculas funcionassem
                    Console.WriteLine("digite o nome do passageiro");
                    usuarios += "- "+Console.ReadLine()+"\n";
                    do {
                        Console.WriteLine("Quer cadastrar outro passageiro? S/N");
                        denovo = Console.ReadLine();
                        if (denovo != "S" && denovo != "N"){
                            Console.WriteLine("Valor inválido");
                        }
                    } while (denovo != "S" && denovo != "N");
                    
                } while (denovo != "N");
            }

        }
    }
}
