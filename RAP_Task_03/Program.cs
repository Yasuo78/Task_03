using System;

namespace RAP_Task_03
{

class Program

{

static void Main(string[] args)

{

int mistakes = 0;

string pass = "СОЧИ";

string EnterPass;

bool res = true;

Console.WriteLine("Введите пароль:");

Console.WriteLine("+ - подсказка");

do

{

Console.WriteLine($"> Попыток {3 - mistakes}");

EnterPass = Convert.ToString(Console.ReadLine());

if (EnterPass == "+")

{

Console.WriteLine(" У русских плохо с паролями");

}else if(pass == EnterPass)

{

res = false;

}else

{

mistakes++;

if(mistakes == 3)

{

Console.WriteLine("Вы привысили лимит попыток. Повторите попытку позже. Нажмите Enter для продолжения.");

Console.ReadKey();

Environment.Exit(0);

}

}

} while (res);

Console.WriteLine("Вход выполнен успешно. Нажмите Enter для получения секретного сообщения.");

Console.ReadKey();

Console.Clear();

Console.WriteLine("Действие игры Black Ops Cold War происходит в начале 1980-х годов.");

Console.WriteLine("░░░░░░░░░░▀▀▀██████▄▄▄░░░░░░░░░░");
Console.WriteLine("░░░░░░░░░░░░░░░░░▀▀▀████▄░░░░░░░");
Console.WriteLine("░░░░░░░░░░▄███████▀░░░▀███▄░░░░░");
Console.WriteLine("░░░░░░░░▄███████▀░░░░░░░▀███▄░░░");
Console.WriteLine("░░░░░░▄████████░░░░░░░░░░░███▄░░");
Console.WriteLine("░░░░░██████████▄░░░░░░░░░░░███▌░");
Console.WriteLine("░░░░░▀█████▀░▀███▄░░░░░░░░░▐███░");
Console.WriteLine("░░░░░░░▀█▀░░░░░▀███▄░░░░░░░▐███░");
Console.WriteLine("░░░░░░░░░░░░░░░░░▀███▄░░░░░███▌░");
Console.WriteLine("░░░░▄██▄░░░░░░░░░░░▀███▄░░▐███░░");
Console.WriteLine("░░▄██████▄░░░░░░░░░░░▀███▄███░░░");
Console.WriteLine("░█████▀▀████▄▄░░░░░░░░▄█████░░░░");
Console.WriteLine("░████▀░░░▀▀█████▄▄▄▄█████████▄░░");
Console.WriteLine("░░▀▀░░░░░░░░░▀▀██████▀▀░░░▀▀██░░");


        }

    }

}