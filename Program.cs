Console.WriteLine("C# Conditions");

Console.WriteLine("Enter student grade.");
double grade = Double.Parse(Console.ReadLine());
Console.WriteLine("Did student paid? (y/n)");
bool paid;
string input = Console.ReadLine() ?? "n";
if ( input == "y")
{
  paid = true;
} else {
    paid = false;
}

if (grade > 60)
{
    if (paid)
    {
        Console.WriteLine("Congratulations");
    } else {
        Console.WriteLine("You need to pay gratuation fees.");
    }
} else {
    Console.WriteLine("Did not graduated");

}

Console.WriteLine("Program ended");