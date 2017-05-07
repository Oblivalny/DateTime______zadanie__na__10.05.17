using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_30__10._05._17
{
    class Program
    {
        private static void BubbleSort(List<int> array)
        {
            for (int i = 0; i < array.LongCount(); i++)
                for (int j = 0; j < array.LongCount() - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }

        static void Main(string[] args)
        {/*Дан файл f, компоненты которого являются целыми числами. Никакая
            из компонент файла не равна нулю. Файл f содержит столько же отри-
            цательных чисел, сколько и положительных. Используя вспомогатель-
            ный файл h, переписать компоненты файла f в файл g так, чтобы в
            файле g сначала шли нечетные потом четные числа.*/

            string text = File.ReadAllText("C:\\Users\\днс\\Desktop\\text.txt");
            string[] count = (text.Split(new char[] { '\r' }));

            List<int> еven = new List<int>();
            List<int> notEven = new List<int>();

            for (int i = 0; i < count.Length; i++)
            {
                if (Convert.ToInt32(count[i]) % 2 == 0)
                {
                    еven.Add(Convert.ToInt32(count[i]));
                }
                else
                {
                    notEven.Add(Convert.ToInt32(count[i]));
                }

            }

            BubbleSort(еven);
            BubbleSort(notEven);

            string[] eevveen = new string[еven.LongCount()];
            string[] noteevveen = new string[notEven.LongCount()];

            for (int i = 0; i < еven.LongCount(); i++)
            {
                Console.WriteLine(еven[i]);
                eevveen[i] = Convert.ToString(еven[i]);
            }
            Console.WriteLine('\r');
            for (int i = 0; i < notEven.LongCount(); i++)
            {
                Console.WriteLine(notEven[i]);
                noteevveen[i] = Convert.ToString(notEven[i]);
            }

         
                File.WriteAllLines( "C:\\Users\\днс\\Desktop\\RETURN.txt", noteevveen);
                File.AppendAllLines("C:\\Users\\днс\\Desktop\\RETURN.txt", eevveen);


            Console.ReadKey();
        }
    }
}

/*
-1
1
-2
2
-3
3
-4
4
-5
5
-6
6
-7
7
-8
7
-9
9
*/
