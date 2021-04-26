using System;

namespace Lojadeitensmagicos
{
    class Program
    {
        static void Main(string[] args)
        {

            int alternativa = 0;
            Loja loja = new Loja();
            Personagem aventureiro = new Personagem();

            do
            {
                Console.WriteLine("Máquina:Digite 1 para: - Menu:Vendedor");
                Console.WriteLine("Máquina:Digite 2 para: - Menu:Cliente");
                Console.WriteLine("Máquina:Digite 0 para: - encerrar \n");
                alternativa = Convert.ToInt16(Console.ReadLine());

                if (alternativa == 1)
                {
                    loja.AddCatalogo();

                }
                else if (alternativa == 2)
                {
                    aventureiro.ApresentacaoAventureiro(aventureiro);
                    aventureiro.ClienteEscolha(loja, aventureiro);
                }
                else if (alternativa != 0)
                {
                    Console.WriteLine("Entrada Invalida");
                }
            } while (alternativa != 0);
            
        }

        

    }
}
