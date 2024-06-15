Main();


void Main()
{   
    Console.WriteLine("Введите целое число: ");
    while (CheckReadLine(ReadLine())){}
}



string ReadLine()
{   
    string? str = Console.ReadLine() ?? "";
    return str;   
} // считывает строку с ввода в консоль 


  // не знаю для чего нужны вопросительные знаки, программа сама вставила их
  // когда ругалась на то, что в str может сохраниться значение NULL

  //                                 ЧТО ДЕЛАТЬ!?


int SummingNumber(int number)
{
    int sumNumber = 0;
    while (number > 0)
    {
        sumNumber += number % 10;
        number /= 10;
    }
    return sumNumber;
} // принимает на вход number и складывает все цифры числа number


bool CheckReadLine (string str)
{   
    if (str == "q" || SummingNumber(Convert.ToInt32(str)) % 2 == 0)
        return false;
    else
        return true;
} // принимает на вход строку и проверяет условие задачи для выхода. Если условия соответствуют выходу, то false, иначе true.