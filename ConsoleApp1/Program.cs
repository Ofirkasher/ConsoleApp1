using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        string now;
        static void Main(string[] args)
        {
            
            foreach (string arg in args)
            {
                if(arg == "ground")
                {
                    ground();
                }
            }
            Console.WriteLine("Welcome Masha\nare you on airplane?");
            string airquestion = "";
            bool b = true;
            Console.WriteLine(airquestion.ToString());
            airquestion = Console.ReadLine();
            if (airquestion.ToLower().Equals("yes"))
            {
                Console.WriteLine("Good for you Mashoshka");
                b = true;
                Console.ReadLine();
                ground();
            }
            if (airquestion.ToLower().Equals("no"))
            {
                Console.WriteLine("Huh, I got confused..Probably..");
                b = false;
                Console.ReadLine();
                whynot();
            }
            else
            {
                goodbye();
            }
            Console.ReadLine();


        }
        static void ground()
        {

            string say1, message1;
            bool b = true;
            message1 = "What are you doin' now?";
            Console.WriteLine("so.....");
            Console.ReadLine();
            Console.WriteLine(message1);
            say1 = Console.ReadLine();
            if (say1.ToLower().Equals(""))
            {
                goodbye();
            }
            else
            {
                Console.WriteLine("oh really? let me quote you, you said '" + say1 + "'\nIs this what are you saying?(yes/no)");
                say1 = Console.ReadLine();
                if (say1.ToLower().Equals("yes"))
                {
                    Console.WriteLine("Jokes on you I dont really care.");
                    b = true;
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (say1.ToLower().Equals("no"))
                {
                    Console.WriteLine("oh...kay...let me ask you the whole over again...");
                    b = false;
                    Console.ReadLine();
                    ground();
                }
                else
                {
                    goodbye();
                }
            }
        }
        static void whynot()
        {
            string answer1;
            Console.WriteLine("Why aren't you on Airplane?");
            answer1 = Console.ReadLine();
            Console.WriteLine("You said '" + answer1 + "'\nSounds terrible, I hope you get into plane soon");
            Console.ReadLine();
            ground();
        }
        static void goodbye()
        {
            Console.WriteLine("lol masha didnt say yes or no\nToo bad, Goodbye");
            Console.ReadLine();
            Environment.Exit(0);

        }
    }
}
