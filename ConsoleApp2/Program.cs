using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp2
{

    public class Program
    {
        public string Teacher(string teacher)
        {
            teacher = @"
 ,--.--------.    ,----.   ,---.       _,.----.  ,--.-,,-,--,    ,----.               
/==/,  -   , -\,-.--` , \.--.'  \    .' .' -   \/==/  /|=|  | ,-.--` , \  .-.,.---.   
\==\.-.  - ,-./==|-  _.-`\==\-/\ \  /==/  ,  ,-'|==|_ ||=|, ||==|-  _.-` /==/  `   \  
 `--`\==\- \  |==|   `.-./==/-|_\ | |==|-   |  .|==| ,|/=| _||==|   `.-.|==|-, .=., | 
      \==\_ \/==/_ ,    /\==\,   - \|==|_   `-' \==|- `-' _ /==/_ ,    /|==|   '='  / 
      |==|- ||==|    .-' /==/ -   ,||==|   _  , |==|  _     |==|    .-' |==|- ,   .'  
      |==|, ||==|_  ,`-./==/-  /\ - \==\.       /==|   .-. ,\==|_  ,`-._|==|_  . ,'.  
      /==/ -//==/ ,     |==\ _.\=\.-'`-.`.___.-'/==/, //=/  /==/ ,     //==/  /\ ,  ) 
      `--`--``--`-----`` `--`                   `--`-' `-`--`--`-----`` `--`-`--`--'  
";

            return teacher;
        }
        static void PaginaDoProf()
        {

            string[] opcoesDoProf = { "Dados do Aluno", "Notas do Aluno", "Presença Do aluno" };
            string imagem = "";
            Menu menu = new Menu();
            Program program = new Program();
            string imagemProf = program.Teacher(imagem);

            menu.DisplayMenu(opcoesDoProf, imagemProf);

        }
        static void Main(string[] args)
        {
            string[] options = { "Pesquisar aluno", "Sair"};
            string artcii = "";

            Menu menu = new Menu();
            Program program = new Program();
            
            string teacherArt = program.Teacher(artcii);
            int selected = menu.DisplayMenu(options,teacherArt);
          

            Console.WriteLine(menu);
            switch (selected)
            {
                case 0:

                    PaginaDoProf();

                    break;
                case 1:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }
        }
    }
}
