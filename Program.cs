using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Original_Name
{
    class Program
    {
        static int Main(string[] args)
        {
            int number = 0;
            char chr = '0';
            Boolean end = true;

            WriteLine("Задача #1");
            WriteLine("Король призвал 2-х мудрецов.");
            WriteLine("И сказал им: \"Я напишу у одного из вас на лбу число,");
            WriteLine("а у другова будет на 1-цу больше или меньше.");
            WriteLine("Вы будете видеть число друг друга,");
            WriteLine("но не знаете свои числа.");
            WriteLine("Их вам и предстоит узнать,");
            WriteLine("или смерть =)\n");

            Sage a = new Sage();
            Sage b = new Sage();

            while (end)
            {
                try
                {
                    Write("Напишите число первого мудреца: ");
                    number = Convert.ToInt32(ReadLine());
                    if (number <= 0 || number >= 10)
                    {
                        WriteLine("Вы ввели недопустимое число!");
                        continue;
                    }
                    a.my_end_number = number;
                    WriteLine("Вы написали число: " + a.my_end_number + ". Это число первого мудреца!\n");
                    
                        Write("Напишите '+' если число больше на 1-цу,\n" +
                              "или '-' если число меньше на 1-цу: ");
                        chr = (char)Read();
                        switch (chr)
                        {
                            case '+':
                                b.my_end_number = a.my_end_number + 1;
                                WriteLine("Теперь у втогоро мудреца число: " + b.my_end_number);
                                break;
                            case '-':
                                if (a.my_end_number - 1 != 0)
                                {
                                    b.my_end_number = a.my_end_number - 1;
                                    WriteLine("Теперь у втогоро мудреца число: " + b.my_end_number);
                                    break;
                                }
                            WriteLine("У второго мудреца не может быть 0!");
                                end = false;
                                break;
                            default:
                                WriteLine("Вы ввели недопустимый знак!");
                            end = false;
                            break;
                        }
                    while (end)
                    {
                        for (int i = 1; end; i++)
                        {
                            if (b.my_end_number == i)
                            {
                                b.my_sage_number = i;
                                a.my_sage_number = ++i;
                                WriteLine("Мудрец первый говорит: \"Я знаю что у меня число - " + a.my_sage_number + "\"");
                                WriteLine("Мудрец второй говорит: \"О и я знаю что у меня число - " + b.my_sage_number + "\"");
                                end = false;
                            }
                            else
                            {
                                WriteLine("Мудрец первый говорит: \"Я не знаю что у меня за число\"");
                                if (a.my_end_number == i)
                                {
                                    a.my_sage_number = i;
                                    b.my_sage_number = ++i;
                                    WriteLine("Мудрец второй говорит: \"Я знаю что у меня число - " + b.my_sage_number + "\"");
                                    WriteLine("Мудрец первый говорит: \"О и я знаю что у меня число - " + a.my_sage_number + "\"");
                                    end = false;
                                }
                                else
                                {
                                    WriteLine("Мудрец второй говорит: \"Я не знаю что у меня за число\"");
                                }
                            }
                        }
                    }
                    end = false;
                }
                catch (Exception e)
                {
                    WriteLine("Вы ввели некорректные символы!");
                }
            }
            ReadKey();
            return (0);
        }
    }
}