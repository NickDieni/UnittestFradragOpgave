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
            //MathiasEksemple();
            //NicksFradrag();
        }

        private static void MathiasEksemple()
        {
            // Hvis vi ønsker at køre unden bruger indput med defalut værdier.
            var arr = new string[] { "Bluse", "Rock", "Hip Hop", "Contry", "Soul" };

            //HVis bruger indput
            //var arr = new string[5];

            //int count = 0;

            //while (count < 5)
            //{
            //    arr[count] = Console.ReadLine();
            //    arr[count] = arr[count];
            //    count++;
            //}

            var result = new DeclarationIndexersAccessorsLikeProperty().TheMusicApp(arr);
            Array.ForEach(result, o => Console.WriteLine(o));
            Console.ReadLine();
        }

        private static void NicksFradrag()
        {
            //var result = new 
        }
    }
}
