// See https://aka.ms/new-console-template for more information
using System.Text;

Random random = new Random();

List<int> bezaoList = new List<int>() { };
StringBuilder display = new StringBuilder();

for(int i = 1; i<28; i++)
{
    here: int number = random.Next(1, 28);
    if (!bezaoList.Contains(number))
    {
        bezaoList.Add(number);
        display.Append($"Person {i} = " + number + "\n");
        Console.WriteLine(display.ToString());
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        goto here;
    }

}
Console.WriteLine("The END!!! \nPress any key to end");

