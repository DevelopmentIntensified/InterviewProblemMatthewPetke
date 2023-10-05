// Index.cs
// Author: Matthew Petke
// Date: 10/03/2023

namespace Index;

class Program
{
    static private Dictionary<string, Shape> options = new Dictionary<string, Shape>();

    static void InsertLine()
    {
        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        options.Add("a", new Triangle());
        options.Add("b", new Square());
        options.Add("c", new Diamond());

        bool shouldRepeat = true;
        char charForShape = 'X';
        Shape SelectedShape = options["a"];
        int heightOfShape = 0;

        do
        {
            Console.WriteLine("Here are the shape options:");
            foreach (KeyValuePair<string, Shape> option in options)
            {
                Console.WriteLine("{0}. {1}", option.Key, option.Value.Name);
            }
            InsertLine();
            Console.WriteLine("What shape would you like me to draw? (Please input the letter associated with the shape)");

            bool hasValidShape = false;
            string? shapeInput;
            while (!hasValidShape)
            {
                try
                {
                    shapeInput = Console.ReadLine();
                    if (shapeInput == null)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if (options.ContainsKey(shapeInput))
                    {
                        hasValidShape = true;
                        SelectedShape = options[shapeInput];
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that is not a valid shape. Please Try again.");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("I'm sorry, that is not a valid shape. Please Try again.");
                }
            }

            Console.WriteLine("How many lines tall do you want the shape to be? (Please answer with a number between {0}-{1})", SelectedShape.MinHeight, SelectedShape.MaxHeight);

            bool hasGivenHeight = false;
            while (!hasGivenHeight)
            {
                try
                {
                    string? heightInput = Console.ReadLine();
                    if (heightInput == null)
                    {
                        Console.WriteLine("Please try again with a vaild integer between 1 adn 25");
                    }
                    try
                    {
                        heightOfShape = Convert.ToInt32(heightInput);
                        if (heightOfShape > SelectedShape.MaxHeight || heightOfShape < SelectedShape.MinHeight)
                        {
                            Console.WriteLine("That number was too big or too small. Please try again.");
                        }
                        else
                        {
                            hasGivenHeight = true;
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is outside the range of the Int32 type. Please try again.", heightInput);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The number inputed is not in a recognizable format. Please try again");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("That input was to long. Please try again");
                }
            }

            InsertLine();
            SelectedShape.Display(heightOfShape, charForShape);
            InsertLine();

            bool hasAnswered = false;
            while (!hasAnswered)
            {
                string? repeatAnswer = "";
                Console.WriteLine("Do you want to draw another shape? (Please include yes or no in your answer)");
                try
                {
                    repeatAnswer = Console.ReadLine();
                    if (repeatAnswer == null)
                    {
                        Console.WriteLine("Please try answering again");
                    }
                    else if (repeatAnswer.ToUpper().Contains("NO"))
                    {
                        Console.WriteLine("Ok, Good Bye!");
                        shouldRepeat = false;
                        hasAnswered = true;
                    }
                    else if (repeatAnswer.ToUpper().Contains("YES"))
                    {
                        Console.WriteLine("Ok");
                        hasAnswered = true;
                    }
                    else
                    {
                        Console.WriteLine("Please try answering again");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Please try answering again");
                }
            }
        } while (shouldRepeat);
    }
}
