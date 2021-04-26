using System;
using System.Collections.Generic;

namespace Lojadeitensmagicos
{
    public class Item
    {
        public string Nome;
        public Int32 Preco;
        public string Categ;
        public string Desc;
        public int Quant;
        public static Item CriarItem()
        {

            Item item = new Item();
            Console.WriteLine("Digite o nome do item: \n");
            item.Nome = Console.ReadLine();
            Console.WriteLine("\nDigite  o preço: \n");
            item.Preco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a categoria: \n");
            item.Categ = Console.ReadLine();
            Console.WriteLine("\nDigite a descrição: \n");
            item.Desc = Console.ReadLine();
            Console.WriteLine("\nDigite a quantidade: \n");
            item.Quant = int.Parse(Console.ReadLine());

            return item;

        }
    }
}
