//Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator 1.1!");
//Console.Write("Enter Length: ");
//double len = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter Width: ");
//double wid = Convert.ToInt32(Console.ReadLine());
//double area = len * wid;
//Console.WriteLine("Area: " + area);
//Console.WriteLine("Perimeter: " + len * 2 + wid * 2);

//if (area < 250)
//{
//    Console.WriteLine("This is a small-sized room");
//}
//else if (area < 650 && area >= 250)
//{
//    Console.WriteLine("This is a medium-sized room");
//}
//else if (area >= 650)
//{
//    Console.WriteLine("This is a large-sized room");
//}

//Console.WriteLine("Thank you for using the Room Detail Generator!");



Console.WriteLine("Welcome to Grand Circus’ Decision Maker 1.2!");
    Console.WriteLine("Please enter a number between 1 and 100");
    int input = Convert.ToInt32(Console.ReadLine());

    bool again = loop(input);

    while (again)
    {
    Console.WriteLine("Please enter a number between 1 and 100");
    input = Convert.ToInt32(Console.ReadLine());
    again = loop(input);
    }
    if (!again)
    {
    Console.WriteLine("Thanks for playing!");
    }



//this fn runs the analyzing loop
static bool loop(int num)
{
    while (num >= 1 && num <= 100)
    {
        if (num % 2 != 0 && num < 60)
        {
            Console.WriteLine(num + " is odd and less than 60");
            return anotherOne();

        }
        else if (num % 2 == 0 && num >= 2 && num <= 24)
        {
            Console.WriteLine(num + " is Even and less than 25");
            return anotherOne();
        }
        else if (num % 2 == 0 && num >= 26 && num <= 60)
        {
            Console.WriteLine(num + " is Even and between 26 and 60 inclusive.");
            return anotherOne();
        }
        else if (num % 2 == 0 && num > 60)
        {
            Console.WriteLine(num + " is Even and greater than 60");
            return anotherOne();
        }
        else if (num % 2 != 0 && num > 60)
        {
            Console.WriteLine(num + " is Odd and greater than 60");
            return anotherOne();
        }
        else
        {
            Console.WriteLine("Whoops, not a vaild number!");
            return anotherOne();
        }
    }
    Console.WriteLine("Whoops, not a vaild number!!");
    return anotherOne();

}

//this fn asks to play again, if answer is yes, return true, if any other answer, return false
static bool anotherOne()
{
    Console.WriteLine("Would you like to play again? Answer yes or no.");

    string[] answers = { "yes", "Yes", "YES" };
    string decision = Console.ReadLine();
    if (answers.Any(a => answers[0] == decision || answers[1] == decision || answers[2] == decision))
    {
        return true;
    }
    else
    {
        return false;
    }

}



