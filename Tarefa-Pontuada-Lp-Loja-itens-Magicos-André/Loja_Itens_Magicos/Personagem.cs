using System;
using System.Collections.Generic;


namespace Loja_Itens_Magicos
{
    public class Personagem
    {
        public string Nome;
        public Int32 Ouro;
        public List<Item> Inventario = new List<Item>();

        public void ApresentacaoAventureiro(Personagem aventureiro)
        {
            Console.Clear();
           Console.WriteLine("Olá,meu nome é: ");
           aventureiro.Nome = Console.ReadLine();
           Console.WriteLine("Vendedor: Quantas moedas de ouro você possui,"+aventureiro.Nome +"?");
           aventureiro.Ouro = int.Parse(Console.ReadLine());
        }

        public String Comprar()
        {
            
            Console.Write("Eu quero comprar: ");
            string carrinho = Console.ReadLine();
            return carrinho;
        }

        public void ClienteEscolha(Loja loja, Personagem aventureiro)
        {
            Console.Clear();
            int alternativa;
            
            do
            {
                Console.WriteLine("Máquina:Digite 1 para: - Acessar o catálogo da loja.");
                Console.WriteLine("Máquina:Digite 2 para: -  Comprar itens."); 
                Console.WriteLine("Máquina:Digite 3 para: - Acessar Inventário");
                Console.WriteLine("0 - voltar");
                alternativa = Convert.ToInt16(Console.ReadLine());
                if (alternativa == 1)
                {
                    loja.ApresentarCatalogo();
                }
                else if (alternativa == 2 && loja.VerificarEstoque() == true)
                {
                    Console.Clear();
                    loja.ApresentarCatalogo();
                    loja.Vender(aventureiro.Comprar(), aventureiro);
                }else if(alternativa == 3)
                {
                    Console.Clear();
                    if(aventureiro.Inventario.Count == 0)
                    {
                        Console.WriteLine("\nMinhas moedas: " + aventureiro.Ouro + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nMinhas moedas: " + aventureiro.Ouro);
                        foreach (var inv in aventureiro.Inventario)
                        {
                            Console.WriteLine("\nNome: " + inv.Nome);
                            Console.WriteLine("Descrição: " + inv.Desc);
                            Console.WriteLine("Quantidade: " + inv.Quant + "\n");
                        }
                    }
                }
                else if (loja.VerificarEstoque() == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nEstoque Vazio,volte mais tarde");
                }
                else if (alternativa != 0)
                {
                    Console.WriteLine("Entrada Invalida");
                }

            } while (alternativa != 0);
            Console.Clear();
        }
    }
}
