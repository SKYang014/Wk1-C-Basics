//intro prompts
bool ask = true;
do
{
    Console.WriteLine("Learn your squares and cubes! Chirpus 1.3\nEnter an integer: ");
    double ogNum = Convert.ToInt32(Console.ReadLine());
    //take input, calculatedata...for loop amount of ints
    //double calcData = Math.Pow(ogNum, ogNum);
    Console.WriteLine("Number\t\tSquared\t\tCubed\n=======\t\t=======\t\t======");
    for (int i = 0; i < ogNum; i++)
    {
        //take calculated data and display table
        Console.WriteLine((i + 1) + "\t\t" + Math.Pow((i + 1), 2) + "\t\t" + Math.Pow((i + 1), 3));
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
} while (ask == true);

