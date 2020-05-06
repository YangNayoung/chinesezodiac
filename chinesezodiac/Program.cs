using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("태어난 연도: ");
            int year = int.Parse(Console.ReadLine());
            int ChineseZodiac = year % 12;

            switch(ChineseZodiac)
            {
                case 0:
                    Console.WriteLine("당신은 원숭이띠 입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신은 닭띠 입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신은 개띠 입니다.");
                    break;
                case 3:
                    Console.WriteLine("당신은 돼지띠 입니다.");
                    break;
                case 4:
                    Console.WriteLine("당신은 쥐띠 입니다.");
                    break;
                case 5:
                    Console.WriteLine("당신은 소띠 입니다.");
                    break;
                case 6:
                    Console.WriteLine("당신은 호랑이띠 입니다.");
                    break;
                case 7:
                    Console.WriteLine("당신은 토끼띠 입니다.");
                    break;
                case 8:
                    Console.WriteLine("당신은 용띠 입니다.");
                    break;
                case 9:
                    Console.WriteLine("당신은 뱀띠 입니다.");
                    break;
                case 10:
                    Console.WriteLine("당신은 말띠 입니다.");
                    break;
                case 11:
                    Console.WriteLine("당신은 양띠 입니다.");
                    break;
            } 
        }
    }
}
