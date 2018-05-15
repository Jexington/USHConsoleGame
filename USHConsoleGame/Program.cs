using System;

namespace USHConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //init
            int hEndingNum = 0;
            int rEndingNum = 0;
            int aEndingNum = 0;
            string choiceTxt = "";

            Console.WriteLine("August 27, 1963. Martin luther king Jr is sitting in his house at his table. Its the day before his big speech and he is struggling to finish his talk he has several different parts in which he has asked the help of his friends.");
            Console.WriteLine("");
            Console.WriteLine("Martin Luther King Jr has been given the option on where to speak. The earlier he goes the less press will be there, but later in the day there will be more press in which he could get what he wanted to say out there.");
            Console.WriteLine("");
            //Choice One
            Console.WriteLine("Choice 1: Speak very first and have little press coverage.");
            Console.WriteLine("Choice 2: Speak somewhere in the middle with press coverage.");
            Console.WriteLine("Choice 3: Speak last and have a ton of the press there.");
            choiceTxt = Console.ReadLine();
            Console.WriteLine(choiceTxt);
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine("King decided it would be best to avoid the press for the most part.");
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King decided to have some press coverage.");
                hEndingNum++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided that the more press the greater his speech would be.");
                rEndingNum++;
                aEndingNum++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("King is struggling finding a way to start his speech");
            Console.WriteLine("");
            //Choice Two
            Console.WriteLine("Choice 1: I am happy to join with you today.");
            Console.WriteLine("Choice 2: We as a people are oppressed and under constant attack and we need to change that.");
            Console.WriteLine("Choice 3: If we as a unified people join together we can change the government.");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine("King choose to stay simple, but optimistic.");
                hEndingNum++;
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King decided to jump straight to the point.");
                rEndingNum++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided to go with an alternative, but ambitious opening line.");
                aEndingNum++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("King is having trouble deciding the start of this paragraph");
            Console.WriteLine("");
            //Choice Three
            Console.WriteLine("Choice 1: Five score years ago a great American in whose symbolic shadow we stand today signed the Emancipation Proclamation.");
            Console.WriteLine("Choice 2: You as Americans passed the emancipation proclamation know it's time to live up to what you passed and start treating us like we deserve.");
            Console.WriteLine("Choice 3: With the passing of the emancipation proclamation we are equal with the whites so we need to act like we are and not let any of there racism and signs keep us out. We can go wherever we want.");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine("King choose to cite America's ideals to stir patriotism amongst his audiance.");
                hEndingNum++;
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King decided an aggressive approach would be the best option.");
                rEndingNum++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided that instead of demanding equality, he would encourage his audiance to fight for it with nonviolence.");
                aEndingNum++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("King needs help with a line to stir the crowd.");
            Console.WriteLine("");
            //Choice Four
            Console.WriteLine("Choice 1: We will beat down the walls of oppression until we gain what we deserve, even if it means if we have to use both our words and our fists.");
            Console.WriteLine("Choice 2: It is time we reform our government towards a new direction, a direction towards harmony of both the black and the white man.");
            Console.WriteLine("Choice 3: So we've come to cash this check, a check that will give us upon demand the riches of freedom and the security of justice.");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine("King chose to use a violent approach, it would likely spark the emotions of several hearts.");
                rEndingNum++;
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King selected an approach to ask for new path with the government, a risky move.");
                aEndingNum++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided to evoke a desire for human rights.");
                hEndingNum++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("King needs an inspirational line this time.");
            Console.WriteLine("");
            //Choice Five
            Console.WriteLine("Choice 1: I have a dream that our government can be changed, where we as a people can live free from American oppression.");
            Console.WriteLine("Choice 2: I have a dream that my four little children will one day live in a nation where they will not be judged by the color of thier skin but by the conent of their character.");
            Console.WriteLine("Choice 3: I have a dream that we as a society can have pure justice, but in order to do so we must stand firmly and not be moved!!");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine("King decided to burst his character and lead away from American patriotism, infact protesting against the country.");
                aEndingNum ++;
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King chose to use pathos in his speech, hoping to rouse kindness from Americans for years to come.");
                hEndingNum ++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided he would try to use the audiance's anger to push his ideas forward.");
                rEndingNum ++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("King needs an ending line that will inspire the crowd.");
            Console.WriteLine("");
            //Choice Six
            Console.WriteLine(@"Choice 1: ""Free at last, free at last, great God a-mighty, We are free at last."" ");
            Console.WriteLine("Choice 2: A new revolution has begun! A revolution where we will tolerate racial injustice no more!");
            Console.WriteLine("Choice 3: From this day forward, I will fight for a reforment of our government to prosper peace throughout the world!");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Choice 1")
            {
                Console.WriteLine(@"King chose to recite the lines of an ""old Negro spiritual.""");
                hEndingNum ++;
            }
            else if (choiceTxt == "Choice 2")
            {
                Console.WriteLine("King decided to use his words to attempt to stir an uprising with his charisma.");
                rEndingNum ++;
            }
            else if (choiceTxt == "Choice 3")
            {
                Console.WriteLine("King decided he would hope to inspire politicians to join him in a new reformation.");
                aEndingNum ++;
            };
            choiceTxt = "";
            Console.WriteLine("");
            if (hEndingNum > rEndingNum && hEndingNum > aEndingNum)
            {
                Console.WriteLine("You got the Historical Ending");
                Console.WriteLine("When King delievered his speech at the Washington March, he shattered expectations, leading America onto a path of racial harmony and past unfair segregation. Great Job! Now try to get the other endings!");
            }
            else if (rEndingNum > hEndingNum && rEndingNum > aEndingNum)
            {
                Console.WriteLine("You got the Violent Ending");
                Console.WriteLine("When King delievered his speech at the Washington March, a riot errupted from the crowd and a massacre took place as both furious citizens and policemen were killed. Now try to get the other endings!");
            }
            else if (aEndingNum > hEndingNum && aEndingNum > hEndingNum)
            {
                Console.WriteLine("You got the Alternative Ending");
                Console.WriteLine("When King delievered his speech at the Washington March, he inspired several politians to join together and create a new major political party, the Harmonists Party, leading the U.S. in a new direction. Now try to get the other endings!");
            }
            else
            {
                Console.WriteLine("You got the Discombobulated Ending");
                Console.WriteLine("When King delievered his speech at the Washington March, he confused almost everyone based on his lack of direction. Now try to get the other endings!");
            }
            Console.WriteLine("");
            Console.WriteLine("Would you like to see the credits?");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Yes")
            {
                Console.WriteLine("");
                Console.WriteLine("Written by Ethan Randall");
                Console.WriteLine("Programmed and written by:");
                Console.WriteLine(" ___________________________");
                Console.WriteLine(" |   ____________________   |");
                Console.WriteLine(" |  |   ___        ___   |  |");
                Console.WriteLine(" |  |--|_O_|------|_O_|--|  |");
                Console.WriteLine(" |  |         __         |  |");
                Console.WriteLine(@" |  |       \____        |  |");
                Console.WriteLine(" |  |                    |  |");
                Console.WriteLine(" |  |_________   ________|  |");
                Console.WriteLine(@" |__|________|\_/|_______|__|");
                Console.WriteLine(@"      |___|__|/ \|__|___|    ");
                Console.WriteLine(@"     /   Derek    ""Jex""  \   ");
                Console.WriteLine(@"    /       Sneddon       \  ");
                Console.WriteLine(@"    -----------------------  ");
            }
            Console.ReadLine();
        }
    }
}
