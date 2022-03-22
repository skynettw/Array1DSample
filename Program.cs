using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10];
            int max = -999, max_index=0;
            int min = 999, min_index=0;
            
            for(int i=0; i<scores.Length; i++)
            {
                Console.Write("{0}號同學的成績：", i+1);
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0; j<scores.Length; j++)
            {
                if (scores[j] > max)
                {
                    max = scores[j];
                    max_index = j;
                }
                if (scores[j] < min)
                {
                    min = scores[j];
                    min_index = j;
                }
            }
            Console.WriteLine("最高分{0}號同學，分數是{1}。", max_index+1, max);
            Console.WriteLine("最低分{0}號同學，分數是{1}。", min_index + 1, min);
            Console.ReadLine();
        }
    }
}
