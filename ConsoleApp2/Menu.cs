using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Menu
    {
        public int DisplayMenu(string[] options, string imagem)
        {
            int selected = 0;
             


            ConsoleKey key;
            do
            {

                Console.Clear();
                Console.WriteLine(imagem);
                for (int i = 0; i < options.Length; i++)
                {
                    

                    if (i == selected)
                    {

                        Console.WriteLine($"> {options[i]}");
                    }
                    else
                    {
                        Console.WriteLine($" {options[i]}");
                    }
                }
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow && selected > 0)
                {
                    selected--;
                }
                else if (key == ConsoleKey.DownArrow && selected < options.Length - 1)
                {
                    selected++;
                }

            } while (key != ConsoleKey.Enter);
            return selected;
        }
    
    }
}
