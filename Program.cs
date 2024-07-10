Console.WriteLine("Hello, welcome to the calculator");

int firstNumber, secondNumber, result;
string userResponse = "";
string operation = "";

do
{
    Console.WriteLine("Plase enter the first number");
    string input1 = Console.ReadLine();
    firstNumber = int.Parse(input1);

    Console.WriteLine("Plase enter the second number");
    string input2 = Console.ReadLine();
    secondNumber = int.Parse(input2);

    Console.WriteLine("Plase enter the operation: +, -, *, / ");
    operation = Console.ReadLine();


    switch (operation) 
    {
        case "+":
            result = firstNumber+secondNumber;
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {result}");
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine($"The subtraction result of {firstNumber} and {secondNumber} is {result}");
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine($"The result of multiplication {firstNumber} and {secondNumber} is {result}");
            break;
        case "/":
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is {result}");
            }
            break;
        default:
           Console.WriteLine("Invalid input");
           break;
     }
    Console.ReadLine();
    Console.WriteLine("Do you want to conntinue? (y/n)");
    userResponse = Console.ReadLine();
  }
while (userResponse == "y" || userResponse == "Y");
 



