
using System.Runtime.CompilerServices;

bool runProgram = true;

while (runProgram)
{
    decimal length = 0;
    decimal width = 0;
    decimal height = 0;

    while (true)
    {
        Console.WriteLine("Please enter a length.");

        string lengthInput = Console.ReadLine();
        length = 0;

        try
        {
            length = decimal.Parse(lengthInput);
            Console.WriteLine("You entered " + length + " for the length.");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid entry, Please only enter numbers without symbols or letters.");
        }
    }

    while (true)
    {
        Console.WriteLine("Please enter a width.");

        string widthInput = Console.ReadLine();
        width = 0;
        try
        {
            width = decimal.Parse(widthInput);
            Console.WriteLine("You entered " + width + " for the width.");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid entry, Please only enter numbers without symbols or letters.");            
        }
    }
    
    while(true)
    {
        Console.WriteLine("Please enter a height.");

        string heightInput = Console.ReadLine();
        height = 0;
        try
        {
            height = decimal.Parse(heightInput);
            Console.WriteLine("You entered " + height + " for the height.");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid entry, Please only enter numbers without symbols or letters.");
        }
    }
    

    decimal area = length * width;
    decimal perimeter = 2 * length + 2 * width;
    decimal volume = length * width * height;
    decimal surfaceArea = 2*(width * length + height * length + height * width);

    Console.WriteLine("Area: " + area);
    Console.WriteLine("Perimeter: " + perimeter);
    Console.WriteLine("Volume: " + volume);
    Console.WriteLine("Surface Area: " + surfaceArea);

    if(area <= 250)
    {
        Console.WriteLine("The room is small.");
    }
    else if(area > 250 && area < 650)
    {
        Console.WriteLine("The room is medium.");
    }
    else
    {
        Console.WriteLine("The room is large.");
    }

    Console.WriteLine("Thank you for using the room detail generator.");
    break;

}
