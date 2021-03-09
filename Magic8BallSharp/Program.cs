using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8BallSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        l_begin:
            string uInput = String.Empty;
            Console.WriteLine("Ask me anything.");
            uInput = Console.ReadLine();

            if (uInput == "")
            {
                Console.WriteLine("Please ask me a question!");
                goto l_begin;
            }
            else
            {
                Console.WriteLine(fetchResponse());
            }

            Console.WriteLine("Would you like to ask me something else? (Y/N)");
            uInput = Console.ReadLine();

            if (uInput.ToUpper() == "Y")
            {
                goto l_begin;
            }
            else
            {
                goto l_end;
            }

        l_end:
            Console.ReadKey();
            return;
        }

        static string fetchResponse()
        {
            Random rand = new Random();
            string[] magicResponsePool = {
                "It is certain.", "It is decidedly so.", "Without a doubt.", "Yes--definitely!",
                "You may rely on it.", "As I see it, yes.", "Most likely.", "Outlook good.",
                "Yes.", "Signs point to yes.", "Reply hazy; try again.", "Ask again later.",
                "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.",
                "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful."
            };

            return magicResponsePool[rand.Next(0, magicResponsePool.Count())];
        }
    }
}
