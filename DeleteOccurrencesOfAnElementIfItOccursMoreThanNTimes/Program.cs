using System;
using System.Collections.Generic;

namespace DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dfd=DeleteNth(new int[] { 2, 2, 1, 2, 2, 3, 2, 2, 1, 2 }, 2);
            Console.WriteLine(dfd);
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> list = new List<int>(arr);
            int Count = 0;
            foreach (int Num in list.ToArray())
            {

                for (int i=0;i< list.Count;i++)
                {
                    if (list[i] == Num)
                    {
                        Count++;
                    }

                    if (Count > x)
                    {
                        list.RemoveAt(i);
                        break;
                    }
                }
                Count = 0;

            }
            int[] Oleg = list.ToArray();
            return Oleg;
        }
    }
}
