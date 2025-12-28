using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a, b, sum,odej,mnoz,dziel;
            int wybor;
            do
            {
                Console.Write("Podaj 1 liczbe:");
                a = uint.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbe:");
                b = uint.Parse(Console.ReadLine());
                Console.WriteLine("---Wybierz dzialanie---");
                Console.WriteLine("1-Dodawanie\n2-Odejmowanie\n3-Mnożenie\n4-Dzielenie\n5-Koniec");
                Console.Write("Wybierz opcję:");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        sum = a + b;
                        Console.WriteLine($"Suma liczb wynosi:{sum}");
                        break;
                    case 2:
                        odej = a - b;
                        Console.WriteLine($"Różnica liczb wynosi:{odej}");
                        break;
                    case 3:
                        mnoz = a * b;
                        Console.WriteLine($"Iloczyn liczb wynosi:{mnoz}");
                        break;
                    case 4:
                        if(b==0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0!!!");
                        }
                        else
                        {
                            dziel = a / b;
                            Console.WriteLine($"Iloraz liczb wynosi:{dziel}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Dziekujemy za korzystania z programu");
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji!!!");
                        break;

                }
            } while (wybor !=5);
           
        }
    }
}
