string input;
do
{
    Console.Write("Enter a number: ");
    input = Console.ReadLine()!;

    if (input != "quit")
    {
        int number = int.Parse(input);

        Console.WriteLine($"DigitIntoLongText: {DigitIntoLongText(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel1: {NumberIntoLongTextLevel1(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel2: {NumberIntoLongTextLevel2(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel3: {NumberIntoLongTextLevel3(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel4: {NumberIntoLongTextLevel4(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel5: {NumberIntoLongTextLevel5(number)}");
    }
}
while (input != "quit");

string DigitIntoLongText(int number)
{
    switch (number)
    {
        case 0: return "zero";
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "not a digit";
    }
}

string NumberIntoLongTextLevel1(int number)
{
    if (number < 10) { return DigitIntoLongText(number); }

    switch (number)
    {
        case 10: return "ten";
        case 11: return "eleven";
        case 12: return "twelve";
        case 13: return "thirteen";
        case 15: return "fifteen";
        case 18: return "eighteen";
        default: return $"{DigitIntoLongText(number % 10)}teen";
    }
}

string NumberIntoLongTextLevel2(int number)
{
    if (number < 20) { return NumberIntoLongTextLevel1(number); }
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    string result;

    switch (leftDigit)
    {
        case 2: result = "twenty"; break;
        case 3: result = "thirty"; break;
        case 4: result = "forty"; break;
        case 5: result = "fifty"; break;
        case 8: result = "eighty"; break;
        default: return $"{DigitIntoLongText(number % 10)}ty";
    }

    if (number % 10 != 0)
    {
        result += DigitIntoLongText(number % 10);
    }

    return result;
}

string NumberIntoLongTextLevel3(int number)
{

    if (number < 100) { return NumberIntoLongTextLevel1(number); }
    if (number > 999) { return "not a valid number"; }

    string result = $"{DigitIntoLongText(number / 100)}hundred";

    if (number % 100 != 0)
    {
        result += NumberIntoLongTextLevel2(number % 100);
    }

    return result;
}

string NumberIntoLongTextLevel4(int number)
{
 
    if (number < 1_000) { return NumberIntoLongTextLevel3(number); }
    if (number > 9_999) { return "not a valid number"; }

   
    string result = $"{DigitIntoLongText(number / 1000)}thousand";

    if (number % 1000 != 0)
    {
        result += NumberIntoLongTextLevel3(number % 1000);
    }

    return result;
}

string NumberIntoLongTextLevel5(int number)
{
    string result = "";
    if (number < 0)
    {
        result = "minus";
        number *= -1;
    } 
    return $"{result}{NumberIntoLongTextLevel4(number)}";
}