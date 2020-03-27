using System;
using System.IO;

namespace Les_1
{

    class Program
    {
        public static int A(string value)
        {
            while (true)
            {
                try
                {
                    Convert.ToInt32(value);
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите снова");
                    value = Console.ReadLine();
                }
            }
            int num = Convert.ToInt32(value);
            return num;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите путь к папке с логами");//C:\Users\Геннадий\source\repos\Les_1\logs
                string dirName = @Console.ReadLine();
                if (Directory.Exists(dirName))
                {
                    while (true)
                    {
                        Console.WriteLine("1-Ввести устройство\nДругое число входящее в int-Выйти из программы");

                        string check =Console.ReadLine();
                        if (A(check) == 1)
                        {
                            Console.WriteLine("Введите название устройства");
                            string Name_devise = Console.ReadLine();
                            string[] files = Directory.GetFiles(dirName);
                            foreach (string s in files)
                            {
                                Console.WriteLine(Pars.Cut(s) + "\t" + Pars.Open(s, Name_devise));
                            }
                        }
                        else
                        {
                            break;
                            
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Папка не найдена, попробуйте снова");
                }
            }
            Console.ReadLine();
        }
    }
}
