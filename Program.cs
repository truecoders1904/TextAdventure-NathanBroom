using System;

namespace InClassDay4
{
    class Program 

    {
        static void Main(string[] args)
        {
            Console.WriteLine("...2040...");

            Console.WriteLine("Hey there stranger. My name is Chip. Chip Elmer. Whats your name?");
            string characterName = Console.ReadLine();


            Console.WriteLine("It's nice to meet you, " + characterName + ". You look confused. Would you like me to tell you what happened?");
            string response = Console.ReadLine();

            if (response == "Yes")

            {
                Console.WriteLine("The year was 2040...Donald Trump and Kim Jong Un could no longer manage thier insecurites" +
                "...they had to see who really had the biggest nuclear bomb. On the tragic day of April 1st they vowed to put an end to their fued" +
                "they synched their watches...at 12:00pm CST they set them off...and life as we knew it changed forever" +
                "98% of the world's population was immediately wiped out...America is now a barren wasteland.");
            }
            else
            {
                Console.WriteLine("Well good luck trying to figure out what happened...");
            }


            Console.WriteLine("Would you like to join me as we try to survive?");

            string response2 = Console.ReadLine();

            if (response == "Yes")
            {
                Console.WriteLine("Well, well, well. It looks you got some smarts down in there somewhere.");
            }
            else
            {
                Console.WriteLine("Good luck surviving on your own...blahhhhhhhh");
            }
        }
    }
}