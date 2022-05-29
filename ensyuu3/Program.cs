using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyuu3
{
    class Program
    {
        static void Main(string[] args)
        {
            //   switch (変数)
            //   {
            //       case 値A: //変数が値Aのとき実行される
            //           文A
            //break;   // 文Aの実行が終わったらswitchから抜ける。
            //       case 値B: //変数が値Bのとき実
            Console.WriteLine("お寿司おみくじ");
            Console.WriteLine("１：まぐろ２：サーモン３：いくら");
            int sushi = int.Parse(Console.ReadLine());
            switch (sushi)//変数sushiに代入された数値による分岐
            {
                case 1:
                    Console.WriteLine("大吉");
                break;

                case 2:
                    Console.WriteLine("中吉");
                    break;
                case 3:
                    Console.WriteLine("凶");
                    break;

            }
        }
    }
}
