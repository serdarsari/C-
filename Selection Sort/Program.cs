﻿using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = { 2, 3, 1, 8, -6,-9 };
            int temp=0;

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[i]>dizi[j])
                    {
                        temp=dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
        }
    }
}
