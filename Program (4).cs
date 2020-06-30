using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //holisterol 120 - 200 walk 1 hour
            //201 - 300 walk 1 hour + stop eating pork
            //301 - 500 walk 1 hour + stop eating + drug
            //501 -- your are probaly dead
            Console.WriteLine("Please enter holisterol");
            int holisterol = Convert.ToInt32(Console.ReadLine());
            if (holisterol >= 120 && holisterol < 201)
                Console.WriteLine("walk 1 hour");
            else if (holisterol >= 201 && holisterol < 301)
                Console.WriteLine("walk 1 hour + stop eating pork");
            else if (holisterol >= 301 && holisterol < 501)
                Console.WriteLine("walk 1 hour + stop eating + drug");
            else if (holisterol >= 501)
                Console.WriteLine("your are probably dead");

            ///better way
            if (holisterol >= 501)
                Console.WriteLine("your are probably dead");
            else if (holisterol >= 301)
                Console.WriteLine("walk 1 hour + stop eating + drug");
            else if (holisterol >= 201)
                Console.WriteLine("walk 1 hour + stop eating pork");
            else if (holisterol >= 120)
                Console.WriteLine("walk 1 hour");


        }

        public static void mikos()
        {
            // 7 meters 20 athletes 8 final
            List<double> athletes = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("give meters");
                athletes.Add(Convert.ToDouble(Console.ReadLine()));
            }
            athletes.Sort();
            for (int i = 19; i > 11; i--)
            {
                Console.WriteLine("Performance {0}", athletes[i]);
            }

            for (int i = 11; i >= 0; i--)
            {
                if (athletes[i] > 7)
                    Console.WriteLine("Performance {0}", athletes[i]);
            }
        }

        public static void Towns()
        {
            //2 Lists town population 2 bigger towns
            List<string> towns = new List<string>();
            List<int> population = new List<int>();
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Town name");
                towns.Add(Console.ReadLine());
                Console.WriteLine("Town population");
                population.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //max 1
            int max = population[0];
            string maxTowns = towns[0];
            for (int i = 1; i <= 4; i++)
            {
                if (population[i] > max)
                {
                    max = population[i];
                    maxTowns = towns[i];
                }
            }
            //max 2
            int max2 = 0;
            string maxTowns2 = "";
            if (maxTowns == towns[0])
            {
                max2 = population[1];
                maxTowns2 = towns[1];
            }
            else
            {
                max2 = population[0];
                maxTowns2 = towns[0];
            }
            for (int i = 0; i <= 4; i++)
            {
                if (population[i] > max2 && towns[i] != maxTowns)
                {
                    max2 = population[i];
                    maxTowns2 = towns[i];
                }
            }

            Console.WriteLine("MAX 1 {0}", maxTowns);
            Console.WriteLine("MAX 2 {0}", maxTowns2);
        }

        public static void navalBattle()
        {
            //naval game array 20 position. 0 where is no ship and 3 1 where ship exist
            int[] array = new int[20];
            Console.WriteLine("please give position");
            int pos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 19; i++)
            {
                if (i == pos || i == pos + 1 || i == pos + 2)
                    array[i] = 1;
                else
                    array[i] = 0;
            }
            bool notSink = true;
            int counter = 0;
            while (notSink)
            {
                Console.WriteLine("please give position");
                int position = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (array[position] == 1)
                {
                    array[position] = 0;
                    Console.WriteLine("You hit it!!");
                }
                else
                    Console.WriteLine("Nothing here");

                if (!array.Contains(1))
                {
                    notSink = false;
                    Console.WriteLine("Well done!!! {0}", counter);
                }
            }
        }

        public static void golf()
        {
            // there 4 golf palyers 4 holes
            int min = 0;
            string winer = "";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please give a name");
                string name = Console.ReadLine();
                int score = 0;

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Please Give your score per hole");
                    score += Convert.ToInt32(Console.ReadLine());
                }
                //min cannot init with 0 value
                //min must init with 1 player score

                if (i == 0)
                    min = score;
                if (score < min)
                {
                    min = score;
                    winer = name;
                }
            }

            Console.WriteLine("the winner is {0} with score {1}", winer, min);
        }

        public static void gambling()
        {
            //rullete 1..12 read credit and if win * 10
            //it stop when user puts 0
            int cashwallet = 2000;
            bool stopflag = true;
            Random rand = new Random();
            while (stopflag && cashwallet > 0)
            {
                Console.WriteLine("please put your bet");
                int bet = Convert.ToInt32(Console.ReadLine());
                if (bet == 0)
                {
                    stopflag = false;
                    Console.WriteLine("thanks for playing");
                }
                else if (bet >= 1 && bet <= 12)
                {
                    Console.WriteLine("please put your cash");
                    int cash = Convert.ToInt32(Console.ReadLine());
                    if (cash > cashwallet || cash < 0)
                    {
                        Console.WriteLine("you don't have enough money");
                    }
                    else
                    {
                        int x = rand.Next(1, 13);
                        int profit;
                        Console.WriteLine("Computer number = {0}", x);
                        if (x == bet)
                        {
                            profit = cash * 9;
                            cashwallet += profit; // cashwallet = cashwallet + profit
                            Console.WriteLine("You Win!! {0}", profit);

                        }
                        else
                        {
                            cashwallet -= cash;
                            Console.WriteLine("You Lost");
                        }
                        Console.WriteLine("Current wallet {0}", cashwallet);
                    }
                }
                else
                {

                    Console.WriteLine("Plese choose a number between 1 .. 12");
                }
            }
        }

        public static void diagwnisma()
        {
            //diwgonisma 10 -5 0
            Console.WriteLine("The name of Greece Prime Minister");
            Console.WriteLine("A. Xamilos");
            Console.WriteLine("B. Papanderou");
            Console.WriteLine("C. Mitsotakis");
            Console.WriteLine("D. Cliton");
            string answer = Console.ReadLine();
            int points = 0; // not need init
            if (answer == "C" || answer == "c")
            {
                points = 10;
            }
            else if (answer != "C" && answer != "")
                points = -5;

            Console.WriteLine("The top football team in world");
            Console.WriteLine("A. Real");
            Console.WriteLine("B. Juve");
            Console.WriteLine("C. Ajax");
            Console.WriteLine("D. Bayern");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                points += 10;
            }
            else if (answer != "A" && answer != "")
                points -= 5;

            Console.WriteLine("Greece Capital City");
            Console.WriteLine("A. Berlin");
            Console.WriteLine("B. NY");
            Console.WriteLine("C. Patra");
            Console.WriteLine("D. Athens");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "D")
            {
                points += 10;
            }
            else if (answer != "D" && answer != "")
                points -= 5;

            Console.WriteLine("total points {0}", points);
        }
    }
}
