//intro prompts
bool ask = true;
do
{
    bool directions = false;
    while (!directions)
    {
        Console.WriteLine("Learn your squares and cubes! Chirpus 1.3\nEnter an integer: ");
        int ogNum = Convert.ToInt32(Console.ReadLine());
        if (ogNum <= 0)
        {
            Console.WriteLine("Whoops, please try again!");
            directions = false;
        }
        else
        {
            directions = true;
            //take input, calculatedata...for loop amount of ints
            //double calcData = Math.Pow(ogNum, ogNum);
            //Console.WriteLine("Number\t\tSquared\t\tCubed\n=======\t\t=======\t\t======");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("  Number|  Squared|   Cubed  ");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < ogNum; i++)
            {
            Console.WriteLine(String.Format("{0,7} | {1,7} | {2,7}", (i + 1), Math.Pow((i + 1), 2), Math.Pow((i + 1), 3)));
            //Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10}", "Edna", "Parker", 114));
            //Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10}", "Johnny", "Depp", 44));
            Console.WriteLine("-------------------------------");
                //take calculated data and display table
                //Console.WriteLine((i + 1) + "\t\t" + Math.Pow((i + 1), 2) + "\t\t" + Math.Pow((i + 1), 3));
            }
            Console.WriteLine("Would you like to get learnt again? (yes or no)");
            string decision = Console.ReadLine();
            if (decision == "yes")
            {
                ask = true;
            }
            else
            {
                Console.WriteLine("Hope you learned alot, goodbye!");
                ask = false;
            }
        }
    }
} while (ask == true);

