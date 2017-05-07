using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici_30_Up__10._05._17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В первом файле хранится k матриц размерности m × n, во втором - l
            матриц размерности m × n. Диагонали матриц из второго файла заме-
            нить диагонали k матриц размерности m × n. 
            Вывести на экран содержимое первого и второго файлов.*/

            string k = File.ReadAllText("C:\\Users\\днс\\Desktop\\text1.txt");
            string l = File.ReadAllText("C:\\Users\\днс\\Desktop\\text2.txt");

            char r = '\n';
            string count = "";
            for (int i = 0; k[i] != r; i++)
            {
                count += k[i];
            }
            string[] strok = count.Split(new Char[] { ' ' });

            string[] stolb = k.Split(new Char[] { '\r' });
            string[] mtrix_text1 = k.Split(new Char[] { '\r',' '});
            string[] mtrix_text2 = l.Split(new Char[] { '\r', ' ' });

            int[,] matrix_K = new int[strok.Length, strok.Length];
            int[,] matrix_L = new int[strok.Length, strok.Length];

            int x = 0;

            for (int i = 0; i < strok.Length; i++)
            {
                for (int j = 0; j < strok.Length; j++)
                {
                    matrix_K[i, j] = Convert.ToInt32(mtrix_text1[x]);
                    x++;
                }   
            }

            x = 0;
            for (int i = 0; i < strok.Length; i++)
            {
                for (int j = 0; j < strok.Length; j++)
                {
                    matrix_L[i, j] = Convert.ToInt32(mtrix_text2[x]);
                    x++;
                }
            }

            for (int i = 0; i < strok.Length; i++)
            {
                matrix_L[i, i] = matrix_K[i, i];
                matrix_L[i, strok.Length - 1 - i] = matrix_K[i, strok.Length-1-i];
            }

            for (int i = 0; i < strok.Length; i++)
            {
                for (int j = 0; j < strok.Length; j++)
                {
                    Console.Write(matrix_K[i,j]+" ");
                }
                Console.WriteLine('\r');
            }

            Console.WriteLine('\r');

            for (int i = 0; i < strok.Length; i++)
            {
                for (int j = 0; j < strok.Length; j++)
                {
                    Console.Write(matrix_L[i, j] + " ");
                }
                Console.WriteLine('\r');
            }

            ///----------- запись двумерного массива в файл -------------

        

     
            for (int i = 0; i <strok.Length; i++)
            {
                if (i == 0)
                {
                    File.WriteAllText("C:\\Users\\днс\\Desktop\\REZALT.txt", "");
                }

                for (int j = 0; j < stolb.Length; j++)
                {                 
                    File.AppendAllText("C:\\Users\\днс\\Desktop\\REZALT.txt", Convert.ToString(matrix_L[i,j]));
                    File.AppendAllText("C:\\Users\\днс\\Desktop\\REZALT.txt", " ");  
                }
                File.AppendAllText("C:\\Users\\днс\\Desktop\\REZALT.txt", "\r");
                File.AppendAllText("C:\\Users\\днс\\Desktop\\REZALT.txt", "\n");
            }

            Console.ReadKey();
        
        }
    }
}
