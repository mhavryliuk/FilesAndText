using System;
using System.IO;
using System.Text;

/* Задание: Напишите программу копирования текстового файла,
 * изменяющей в копии файла символ пробела на символ точка с запятой. */

namespace Collection01
{
    class Program
    {
        static void Main()
        {
            try
            {
                File.Copy(@"D:\Poem.txt", @"D:\ResultPoem.txt", true);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка при создания копии файла.");
                Console.WriteLine("Причина:\n" + exc.Message);
            }

            try
            {
                StreamReader reader = new StreamReader(@"D:\ResultPoem.txt", Encoding.Default);
                string content = reader.ReadToEnd();
                content = content.Replace(' ', ';');
                reader.Close();

                StreamWriter writer = new StreamWriter(@"D:\ResultPoem.txt");
                writer.Write(content);
                writer.Close();
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }

            Console.ReadKey();
        }
    }
}