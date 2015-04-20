using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAdventure
{
    class Program
    {



        static void Main(string[] args)
        {
        
            while(true)
            {
                Console.Write("Write Something. \n");
                string Something = Console.ReadLine();
                PrintText("You Wrote: " + Something + "\n");

                PrintText("................\n");

                PrintText("Do You Want To Exit: Yes Or No \n");

                string yesOrNo = Console.ReadLine();

                if(yesOrNo.ToLower() == "yes")
                {
                    Environment.Exit(0);
                }

                


            }

            


        }

       static void PrintText(string Text)
        {
            for (int Letter = 0; Letter < Text.Length; Letter++)
            {
                Thread.Sleep(50);
                Console.Write("{0}", Text[Letter]);
                Console.Beep();
                
            }
        }
    }
}
