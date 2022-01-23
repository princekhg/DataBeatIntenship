using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        int[] num;
        // program to read value in the array
        public void read()
        {
            int Len;
            Console.WriteLine("Enter length of array");
            Len = Convert.ToInt32(Console.ReadLine());
            num = new int[Len];
            Console.WriteLine("Enter array values");
            for (int i = 0; i < Len; i++)
                num[i] = Convert.ToInt32(Console.ReadLine());
        }
        // method to perform Buuble Sort
        public void BubbleSort()
        {
            int temp;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                { // method to perform elemnts swapping
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
        }

        // method to display the sorted array
        public void display()
        {
            foreach (int n in num)
            {
                Console.Write(n + ",");
            }
            Console.Read();
        }
        // Final calling method to call the objects 
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.read();
            pg.BubbleSort();
            pg.display();
        }
    }
}
