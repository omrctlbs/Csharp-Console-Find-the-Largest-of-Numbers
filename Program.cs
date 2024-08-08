// Finding the largest of the three numbers entered

Console.WriteLine("Enter the first number:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number:");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("The first number is the largest.");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine("The second number is the largest.");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("The third number is the largest.");
}
else
{
    Console.WriteLine("Please enter a valid value.");
}
