// See https://aka.ms/new-console-template for more information

bool repeat= true;
string repeatCharacter;
int number1;
int number2;


while (repeat)
{


Console.Write("1つ目の数字を入力してください： ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2つ目の数字を入力してください： ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("和:" +  (number1+number2));

if (number1 > number2)
{
    Console.WriteLine("差:" + (number1 + number2));
}
else
{
    Console.WriteLine("差:" + (number2 - number1));
}

Console.WriteLine("積:" + number1 * number2);


Console.WriteLine("商:" + number1 / number2);


    Console.Write("続きますか？(Y/N)");
    repeatCharacter = Console.ReadLine();
    if (repeatCharacter != "y")
    {
        repeat = false;
    }
    else
    {
        Console.WriteLine("");
    }

}