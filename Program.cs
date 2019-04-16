using System;

namespace InClassDay4
{
    class Program

    {
        // Getting User Response
        static string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string UserResponse = Console.ReadLine();
            return UserResponse;

        }
        //Dramatic Text
        static void TextPause(string DramaticStatment)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(DramaticStatment);
            System.Threading.Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            //Game Title 
            Console.WriteLine("\n                                                                            \n                                                                            \n 222222222222222         000000000            444444444   333333333333333   \n2:::::::::::::::22     00:::::::::00         4::::::::4  3:::::::::::::::33 \n2::::::222222:::::2  00:::::::::::::00      4:::::::::4  3::::::33333::::::3\n2222222     2:::::2 0:::::::000:::::::0    4::::44::::4  3333333     3:::::3\n            2:::::2 0::::::0   0::::::0   4::::4 4::::4              3:::::3\n            2:::::2 0:::::0     0:::::0  4::::4  4::::4              3:::::3\n         2222::::2  0:::::0     0:::::0 4::::4   4::::4      33333333:::::3 \n    22222::::::22   0:::::0 000 0:::::04::::444444::::444    3:::::::::::3  \n  22::::::::222     0:::::0 000 0:::::04::::::::::::::::4    33333333:::::3 \n 2:::::22222        0:::::0     0:::::04444444444:::::444            3:::::3\n2:::::2             0:::::0     0:::::0          4::::4              3:::::3\n2:::::2             0::::::0   0::::::0          4::::4              3:::::3\n2:::::2       2222220:::::::000:::::::0          4::::4  3333333     3:::::3\n2::::::2222222:::::2 00:::::::::::::00         44::::::443::::::33333::::::3\n2::::::::::::::::::2   00:::::::::00           4::::::::43:::::::::::::::33 \n22222222222222222222     000000000             4444444444 333333333333333   \n                                                              ");
            System.Threading.Thread.Sleep(1500);

            //Beginning the game 
                //****try to figure out way to make text blink
            GetUserResponse("Press 'Enter' to continue.");
            Console.Clear();

            //Scene 1
            Console.WriteLine("You slowly wake up...");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();


            TextPause("\"Man it feels like I've been knocked out for days,\" you mutter to yourself.");
            Console.Clear();

            TextPause("You start to walk around to try to figure out your suroundings.");
            Console.Clear();


            TextPause("It appears you are on the outskirts of a city.");
           

            //First Choice
            System.Threading.Thread.Sleep(1000);
            string response = GetUserResponse("Would you like to go into the city?");

            if (response.ToLower() == "yes")
            {
                TextPause("You walk into the city.");

                TextPause("The city looks barren and basically destroyed.");
                Console.Clear();

                TextPause("\"What happened here? Where is everyone?\", you think to yourself.");

                TextPause("You need to find someone or something to help you figure out what happened.");

                string intersectionChoice;
                do
                {
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("You find yourself at an intersection. You have four choices.");
                    Console.WriteLine("Left");
                    Console.WriteLine("Right");
                    Console.WriteLine("Straight");
                    Console.WriteLine("Back the way you came");

                    Console.WriteLine("Which way would you like to choose?");
                    intersectionChoice = Console.ReadLine();

                    if (intersectionChoice.ToLower() == "right")
                    {
                        Console.WriteLine("You try to turn to the right but you see the way is blocked by a collasped \n bridge.");
                    }
                    else if (intersectionChoice.ToLower() == "straight")
                    {
                        Console.WriteLine("You head straight and are chased by rabid dogs.");
                    }
                    else if (intersectionChoice.ToLower() == "back the way you came")
                    {
                        Console.WriteLine("As you turn around you see a sign that reads \"ALL THOSE WHO LEAVE DIE\". \n Maybe this is the wrong choice...");
                    }
                    else if (intersectionChoice.ToLower() == "left")
                    {
                        Console.WriteLine("You head down to the left and way off in the distance you see what seems \n to be a person!!");
                    }
                    else
                    {
                        Console.WriteLine("(response not recognized)");
                    }
                } while (intersectionChoice.ToLower() != "left");

                string response2 = GetUserResponse("Do you want to follow him?");
                if (response2.ToLower() == "yes")
                {
                    Console.WriteLine("You follow him from a distance while trying to remain discrete." +
                    	"As you get closer you see him enter a building.");
                   
                     string response3 = GetUserResponse("Do you want to risk it and enter after him?");
                    if (response3.ToLower() == "yes")
                    {
                        Console.WriteLine("Surprise it's your birthday! Congrats you win!!!");
                    }

                }
                else
                {
                    Console.WriteLine("You remain alone and die slowly and painfully...");
                }
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("You see a group of buildings away from the city on a hillside in the distance and walk toward them.");
            }

        }
    }
}
//string characterName = Console.ReadLine();


//Console.WriteLine("It's nice to meet you, " + characterName + ". You look confused. Would you like me to tell you what happened?");
//string response = Console.ReadLine();

//if (response.ToLower() == "yes")

//{
//    Console.WriteLine("The year was 2043...Donald Trump and Kim Jong Un could no longer manage thier insecurites" +
//    "...they had to see who really had the biggest nuclear bomb... \n");
//    System.Threading.Thread.Sleep(1500);
//    Console.WriteLine("On the tragic day of April 1st they vowed to put an end to their fued" +
//    "they synched their watches...at 12:00pm CST they set them off...and life as we knew it changed forever" +
//    "98% of the world's population was immediately wiped out...America is now a barren wasteland.");
//}
//else
//{
//    Console.WriteLine("Well good luck trying to figure out what happened...");
//}



//Console.WriteLine("Would you like to join me as we try to survive?");

//string response2 = Console.ReadLine();

//if (response2.ToLower() == "Yes")
//{
//    Console.WriteLine("Well, well, well. It looks you got some smarts down in there somewhere.");
//}
//else
//{
//    Console.WriteLine("Good luck surviving on your own...");
//}
//Console.WriteLine();
//Console.ReadLine();