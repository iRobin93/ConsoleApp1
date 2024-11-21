Main();



void Main()
{
    int number1 = 1;
    int number2 = 5;

    var sum = ReturnNumbers(number1, number2);

    Console.WriteLine(sum);
    Console.WriteLine("denne metoden returnerer ingen ting");
}

int ReturnNumbers(int number1, int number2)
{
    var number3 = number1 + number2;
    return number3;
}