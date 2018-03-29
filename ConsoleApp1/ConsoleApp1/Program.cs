using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 供玩家設定6選擇個數字
            int v1;
            int v2;
            int v3;
            int v4;
            int v5;
            int v6;

            while (true)
            {
                Console.WriteLine("請輸入您這期簽選的大樂透號碼:");

                Console.WriteLine("第一個:");
                v1 = Convert.ToInt32(Console.ReadLine());
                if (v1 < 1 || v1 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                Console.WriteLine("第二個:");
                v2 = Convert.ToInt32(Console.ReadLine());
                if (v2 < 1 || v2 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                Console.WriteLine("第三個:");
                v3 = Convert.ToInt32(Console.ReadLine());
                if (v3 < 1 || v3 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                Console.WriteLine("第四個:");
                v4 = Convert.ToInt32(Console.ReadLine());
                if (v4 < 1 || v4 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                Console.WriteLine("第五個:");
                v5 = Convert.ToInt32(Console.ReadLine());
                if (v5 < 1 || v5 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                Console.WriteLine("第六個:");
                v6 = Convert.ToInt32(Console.ReadLine());
                if (v6 < 1 || v6 > 42)
                {
                    Console.WriteLine("請選擇正確的數字");
                    continue;
                }

                break;
            }

            // 產生亂數物件
            Random rand = new Random();

            // 設定6個樂透號碼,並產生１０組

            for (int a = 0; a < 9; a++)
            {
                int[] randL = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    randL[i] = rand.Next(1, 42);

                    for (int j = 0; j < i; j++)
                    {
                        while (randL[j] == randL[i])
                        {
                            j = 0;
                            randL[i] = rand.Next(1, 42);
                        }
                    }
                }
                int r1 = randL[0];
                int r2 = randL[1];
                int r3 = randL[2];
                int r4 = randL[3];
                int r5 = randL[4];
                int r6 = randL[5];

                // 顯示

                Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r1, r2, r3, r4, r5, r6);
            }
            Console.ReadLine();            
        }
    }
}
